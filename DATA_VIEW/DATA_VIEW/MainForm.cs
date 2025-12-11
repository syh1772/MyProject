using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using Excel = Microsoft.Office.Interop.Excel;

namespace SEMCNS.DATA_VIEW
{
    public partial class MainForm : Form
    {
        public class Via
        {
            public string Name { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public string ImagePath { get; set; }

            public Via(string name, double x, double y, string imagePath)
            {
                this.Name = name;
                this.X = x;
                this.Y = y;
                this.ImagePath = imagePath;
            }
        }

        Dictionary<string, Via> _viaDic;
        string _currentFileName = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            _viaDic = new Dictionary<string, Via>();

            dgvMain.Columns.Add("Name", "Name");
            dgvMain.Columns.Add("Reg X", "Reg X");
            dgvMain.Columns.Add("Reg Y", "Reg Y");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dlg = new CommonOpenFileDialog())
            {
                dlg.IsFolderPicker = true;

                if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    // dlg.FileName은 경로 및 확장자 포함
                    lblPath.Text = dlg.FileName;
                    SetDataGridView(dlg.FileName);

                    // 폴더만 가져옴(엑셀파일로 저장할 때 이 이름으로 저장)
                    _currentFileName = Path.GetFileName(dlg.FileName);
                }
                else
                {
                    _currentFileName = string.Empty;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SetDataGridView(string folderPath)
        {
            try
            {
                // 지정 경로내 모든 파일 가져오기
                var files = Directory.GetFiles(folderPath).OrderBy(f => f);

                _viaDic.Clear();
                dgvMain.Rows.Clear();

                foreach (string file in files)
                {
                    // 확장자 없이 파일명만 가져와 Split
                    string strTemp = Path.GetFileNameWithoutExtension(file);
                    string[] splitString = strTemp.Split('_');

                    // 파일명에 RegX, RegY 있으면 값 가져옴
                    if (strTemp.IndexOf("RegX", StringComparison.OrdinalIgnoreCase) == -1)
                    {
                        continue;
                    }
                    else if (strTemp.IndexOf("RegY", StringComparison.OrdinalIgnoreCase) == -1)
                    {
                        continue;
                    }

                    double regX = 0;
                    double regY = 0; ;
                    string name = splitString[0];

                    for (int i = 0; i < splitString.Length; i++)
                    {
                        // 파일명에 RegX, RegY 있으면 값 가져옴
                        if (splitString[i].StartsWith("RegX", StringComparison.OrdinalIgnoreCase))
                        {
                            regX = double.Parse(splitString[i].Substring(4));
                        }
                        else if (splitString[i].StartsWith("RegY", StringComparison.OrdinalIgnoreCase))
                        {
                            regY = double.Parse(splitString[i].Substring(4));
                        }
                    }

                    // 이름값은 파일명에서 RegX 앞부분까지 할당
                    name = strTemp.Substring(0, strTemp.IndexOf("RegX", StringComparison.OrdinalIgnoreCase) - 1);

                    // Dictionary 자료 및 화면 할당
                    _viaDic.Add(name, new Via(name, regX, regY, file));
                }

                // 인접한 비아 제외 기능 추가 
                if (ckbGroupingVia.Checked == true)
                {
                    try
                    {
                        double toleranceX = double.Parse(txtToleranceX.Text);
                        double toleranceY = double.Parse(txtToleranceY.Text);
                        _viaDic = PointFilter(_viaDic, toleranceX, toleranceY);
                    }
                    catch (Exception ex)
                    {

                    }
                }

                foreach (var item in _viaDic)
                {
                    dgvMain.Rows.Add(item.Value.Name, item.Value.X, item.Value.Y);
                }

                // Via 이미지 갱신
                pnlStf.Invalidate();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // 데이터 선택하면 이미지 표시
                if (dgvMain.CurrentRow != null)
                {
                    // 선택한 열
                    DataGridViewRow row = dgvMain.CurrentRow;

                    // 첫번째 열(Name)을 key로
                    string key = row.Cells[0].Value.ToString();

                    // Dictionary에 저장된 파일 경로로 이미지 로드
                    picDisplay.Load(_viaDic[key].ImagePath);

                    // Via 이미지 갱신
                    pnlStf.Invalidate();

                    // 비아 정보 출력
                    lblName.Text = "Name : " + key;
                    lblPos.Text = "Pos : " + _viaDic[key].X + ", " + _viaDic[key].Y;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        // 원(STF)을 그리고 비아 그리기
        private void pnlStf_Paint(object sender, PaintEventArgs e)
        {
            int centerX = this.pnlStf.Width / 2;
            int centerY = this.pnlStf.Height / 2;
            int radius = 150;
            int diameter = radius * 2;

            e.Graphics.FillEllipse(new SolidBrush(Color.LimeGreen),
                new System.Drawing.Rectangle(centerX - radius, centerY - radius, diameter, diameter));

            int viaDiameter = 4;

            // 현재 경로에 모든 비아 그리기
            using (Pen pen = new Pen(Color.Yellow, 1))
            {
                foreach (var via in _viaDic)
                {
                    e.Graphics.DrawEllipse(pen, centerX + (float)via.Value.X - viaDiameter / 2,
                        centerY - (float)via.Value.Y - viaDiameter / 2, viaDiameter, viaDiameter);
                }
            }

            // 선택된 비아 그리기
            if (dgvMain.CurrentRow != null)
            {
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    // 선택한 열
                    DataGridViewRow row = dgvMain.CurrentRow;

                    // 첫번째 열(Name)을 key로
                    string key = row.Cells[0].Value.ToString();

                    e.Graphics.DrawEllipse(pen, centerX + (float)_viaDic[key].X - viaDiameter / 2,
                        centerY - (float)_viaDic[key].Y - viaDiameter / 2, viaDiameter, viaDiameter);
                }
            }
        }

        private void txtToleranceX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자 또는 Backspace만 입력
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        Dictionary<string, Via> PointFilter(Dictionary<string, Via> source, double toleranceX, double toleranceY)
        {
            Dictionary<string, Via> filterDic = new Dictionary<string, Via>();

            foreach (var currentDic in source)
            {
                bool isTooClose = false;

                // 인접한 좌표가 필터링된 자료에 있는지 확인
                foreach (var dic in filterDic)
                {
                    if (Math.Abs(currentDic.Value.X - dic.Value.X) <= toleranceX &&
                        Math.Abs(currentDic.Value.Y - dic.Value.Y) <= toleranceY)
                    {
                        isTooClose = true;
                        break;
                    }
                }

                if (isTooClose == false)
                {
                    filterDic.Add(currentDic.Key, currentDic.Value);
                }
            }

            return filterDic;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                if(excel == null)
                {
                    MessageBox.Show("엑셀이 설치되지 않았습니다.");
                    return;
                }

                if(dgvMain.Rows.Count > 1)
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Title = "Save as Excel File";
                    dlg.Filter = "Excel Documents (*xls)|*.xls";
                    dlg.FileName = _currentFileName + ".xls";

                    if(dlg.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                        Excel.Worksheet workSheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
                        workSheet.Name = "DataView";
                        excel.DisplayAlerts = false;

                        // 헤더 출력
                        for (int i = 0; i < dgvMain.Columns.Count - 1; i++)
                        {
                            workSheet.Cells[1, i + 1] = dgvMain.Columns[i].HeaderText;
                        }

                        // 내용 출력
                        for (int i = 0; i < dgvMain.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvMain.Columns.Count - 1; j++)
                            {
                                workSheet.Cells[i + 2, j + 1] = dgvMain.Rows[i].Cells[j].Value;
                            }
                        }

                        // 글자 크기에 맞게 셀 크기를 자동으로 조절
                        workSheet.Columns.AutoFit();

                        // 엑셀 2003 으로만 저장이 됨
                        workbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        workbook.Close(Type.Missing, Type.Missing, Type.Missing); excel.Quit();
                    }
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
