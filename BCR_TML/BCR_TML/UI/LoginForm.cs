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
    public partial class LoginForm : Form
    {
        public string ID { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtId;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ID = txtId.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtId.Focus();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Name.Contains("btnNum"))
            {
                // 마지막 글자로 입력 버튼 구분
                string buttonId = clickedButton.Name.Substring(clickedButton.Name.Length - 1);
                txtId.Text += buttonId;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // 마지막 글자 지우기
            if(txtId.Text != string.Empty)
            {
                txtId.Text = txtId.Text.Substring(0, txtId.Text.Length - 1);
            }

            txtId.Focus();
        }
    }
}