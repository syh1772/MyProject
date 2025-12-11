namespace SEMCNS.DATA_VIEW
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlStf = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.ckbGroupingVia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToleranceX = new System.Windows.Forms.TextBox();
            this.txtToleranceY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelectFolder.Location = new System.Drawing.Point(32, 26);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(96, 40);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "폴더 선택";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPath.Location = new System.Drawing.Point(134, 26);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(719, 61);
            this.lblPath.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(1013, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "프로그램 종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(413, 90);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(376, 332);
            this.picDisplay.TabIndex = 4;
            this.picDisplay.TabStop = false;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(32, 90);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(375, 580);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // pnlStf
            // 
            this.pnlStf.Location = new System.Drawing.Point(795, 90);
            this.pnlStf.Name = "pnlStf";
            this.pnlStf.Size = new System.Drawing.Size(347, 332);
            this.pnlStf.TabIndex = 6;
            this.pnlStf.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStf_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(419, 432);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name : ";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblPos.Location = new System.Drawing.Point(419, 457);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(64, 25);
            this.lblPos.TabIndex = 9;
            this.lblPos.Text = "Pos : ";
            // 
            // ckbGroupingVia
            // 
            this.ckbGroupingVia.AutoSize = true;
            this.ckbGroupingVia.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.ckbGroupingVia.Location = new System.Drawing.Point(14, 27);
            this.ckbGroupingVia.Name = "ckbGroupingVia";
            this.ckbGroupingVia.Size = new System.Drawing.Size(229, 25);
            this.ckbGroupingVia.TabIndex = 10;
            this.ckbGroupingVia.Text = "인접한 비아 제외 기능 사용";
            this.ckbGroupingVia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "X 범위 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y 범위 : ";
            // 
            // txtToleranceX
            // 
            this.txtToleranceX.Location = new System.Drawing.Point(94, 64);
            this.txtToleranceX.Name = "txtToleranceX";
            this.txtToleranceX.Size = new System.Drawing.Size(53, 23);
            this.txtToleranceX.TabIndex = 13;
            this.txtToleranceX.Text = "1.5";
            this.txtToleranceX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToleranceX_KeyPress);
            // 
            // txtToleranceY
            // 
            this.txtToleranceY.Location = new System.Drawing.Point(94, 94);
            this.txtToleranceY.Name = "txtToleranceY";
            this.txtToleranceY.Size = new System.Drawing.Size(53, 23);
            this.txtToleranceY.TabIndex = 14;
            this.txtToleranceY.Text = "1.5";
            this.txtToleranceY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToleranceX_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(153, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(153, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "mm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbGroupingVia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtToleranceY);
            this.groupBox1.Controls.Add(this.txtToleranceX);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(795, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 218);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기능";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Location = new System.Drawing.Point(859, 26);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(129, 40);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "엑셀로 변환";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 682);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlStf);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlStf;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.CheckBox ckbGroupingVia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToleranceX;
        private System.Windows.Forms.TextBox txtToleranceY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
    }
}

