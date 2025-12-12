using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMCNS.BCR_TML
{
    public partial class MainForm : Form
    {
        string _currentUserId = string.Empty;
        public MainForm()
        {
            InitializeComponent();

            ucEqptId.Init("장비명");
            ucEqptId.UpdateContext("AOI 검사 1호기");
            ucOperatorId.Init("작업자명");
            ucOperatorId.UpdateContext("20251021 신윤호");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLotStart_Click(object sender, EventArgs e)
        {
            if (_currentUserId == string.Empty)
            {
                MessageBox.Show("사번을 입력해주세요");
                return;
            }

            if (txtLotId.Text == string.Empty)
            {
                MessageBox.Show("제품을 스캔해주세요");
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("작업 시작\n");
            sb.AppendFormat("투입 제품 : " + txtLotId.Text + "\n");
            sb.AppendFormat("작업자 : " + _currentUserId + "\n");

            ucMainMessage.UpdateMessage(ucMessage.MESSAGE_TYPE.LotStart, sb.ToString());
        }

        private void btnLotEnd_Click(object sender, EventArgs e)
        {
            if (txtLotId.Text == string.Empty)
            {
                MessageBox.Show("작업중인 제품이 없습니다.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("작업 종료\n");
            sb.AppendFormat("투입 제품 : " + txtLotId.Text + "\n");
            sb.AppendFormat("작업자 : " + _currentUserId + "\n");

            ucMainMessage.UpdateMessage(ucMessage.MESSAGE_TYPE.LotEnd, sb.ToString());

            txtLotId.Text = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _currentUserId = loginForm.ID;

                    StringBuilder sb = new StringBuilder();

                    sb.AppendFormat("로그인 성공\n");
                    sb.AppendFormat("작업자 : " + _currentUserId + "\n");

                    ucMainMessage.UpdateMessage(ucMessage.MESSAGE_TYPE.Login, sb.ToString());
                    ucOperatorId.UpdateContext(loginForm.ID);
                }
            }
        }

        private void txtLotId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLotStart_Click(sender, e);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TerminalDevice.Terminal.SendMessage(txtLotId.Text);
        }
    }
}
