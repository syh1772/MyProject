namespace SEMCNS.BCR_TML
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLotStart = new System.Windows.Forms.Button();
            this.btnLotEnd = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucOperatorId = new SEMCNS.BCR_TML.ucContextDisplay();
            this.ucEqptId = new SEMCNS.BCR_TML.ucContextDisplay();
            this.ucMainMessage = new SEMCNS.BCR_TML.ucMessage();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(604, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 75);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "프로그램 종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLotStart
            // 
            this.btnLotStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLotStart.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btnLotStart.Location = new System.Drawing.Point(447, 526);
            this.btnLotStart.Name = "btnLotStart";
            this.btnLotStart.Size = new System.Drawing.Size(151, 75);
            this.btnLotStart.TabIndex = 1;
            this.btnLotStart.Text = "작업 시작";
            this.btnLotStart.UseVisualStyleBackColor = false;
            this.btnLotStart.Click += new System.EventHandler(this.btnLotStart_Click);
            // 
            // btnLotEnd
            // 
            this.btnLotEnd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLotEnd.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btnLotEnd.Location = new System.Drawing.Point(604, 445);
            this.btnLotEnd.Name = "btnLotEnd";
            this.btnLotEnd.Size = new System.Drawing.Size(151, 75);
            this.btnLotEnd.TabIndex = 2;
            this.btnLotEnd.Text = "작업 종료";
            this.btnLotEnd.UseVisualStyleBackColor = false;
            this.btnLotEnd.Click += new System.EventHandler(this.btnLotEnd_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(604, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 75);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLotId
            // 
            this.txtLotId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLotId.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.txtLotId.Location = new System.Drawing.Point(154, 547);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(262, 34);
            this.txtLotId.TabIndex = 7;
            this.txtLotId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "바코드 입력 :";
            // 
            // ucOperatorId
            // 
            this.ucOperatorId.Location = new System.Drawing.Point(425, 21);
            this.ucOperatorId.Name = "ucOperatorId";
            this.ucOperatorId.Size = new System.Drawing.Size(173, 80);
            this.ucOperatorId.TabIndex = 6;
            // 
            // ucEqptId
            // 
            this.ucEqptId.Location = new System.Drawing.Point(22, 21);
            this.ucEqptId.Name = "ucEqptId";
            this.ucEqptId.Size = new System.Drawing.Size(173, 80);
            this.ucEqptId.TabIndex = 5;
            // 
            // ucMainMessage
            // 
            this.ucMainMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMainMessage.Location = new System.Drawing.Point(22, 107);
            this.ucMainMessage.Name = "ucMainMessage";
            this.ucMainMessage.Size = new System.Drawing.Size(576, 413);
            this.ucMainMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btnSend.Location = new System.Drawing.Point(604, 284);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(151, 75);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "명령 전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 613);
            this.ControlBox = false;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLotId);
            this.Controls.Add(this.ucOperatorId);
            this.Controls.Add(this.ucEqptId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ucMainMessage);
            this.Controls.Add(this.btnLotEnd);
            this.Controls.Add(this.btnLotStart);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLotStart;
        private System.Windows.Forms.Button btnLotEnd;
        private ucMessage ucMainMessage;
        private System.Windows.Forms.Button btnLogin;
        private ucContextDisplay ucEqptId;
        private ucContextDisplay ucOperatorId;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
    }
}

