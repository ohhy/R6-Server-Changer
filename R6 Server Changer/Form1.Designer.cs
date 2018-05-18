namespace R6_Server_Changer
{
    partial class Form1
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
            this.select_server = new System.Windows.Forms.Button();
            this.server_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.file_path = new System.Windows.Forms.Button();
            this.file_path_label = new System.Windows.Forms.Label();
            this.OpenFile_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selected_server = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select_server
            // 
            this.select_server.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select_server.Location = new System.Drawing.Point(374, 12);
            this.select_server.Name = "select_server";
            this.select_server.Size = new System.Drawing.Size(198, 82);
            this.select_server.TabIndex = 0;
            this.select_server.Text = "서버 변경 확인";
            this.select_server.UseVisualStyleBackColor = true;
            this.select_server.Click += new System.EventHandler(this.select_server_Click);
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_label.Location = new System.Drawing.Point(372, 100);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(114, 23);
            this.server_label.TabIndex = 2;
            this.server_label.Text = "선택된 서버 : ";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.state_label.Location = new System.Drawing.Point(9, 335);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(45, 17);
            this.state_label.TabIndex = 3;
            this.state_label.Text = "상태 : ";
            // 
            // file_path
            // 
            this.file_path.Font = new System.Drawing.Font("굴림", 10F);
            this.file_path.Location = new System.Drawing.Point(12, 281);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(98, 51);
            this.file_path.TabIndex = 4;
            this.file_path.Text = "파일선택";
            this.file_path.UseVisualStyleBackColor = true;
            this.file_path.Click += new System.EventHandler(this.file_path_Click);
            // 
            // file_path_label
            // 
            this.file_path_label.AutoSize = true;
            this.file_path_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.file_path_label.Location = new System.Drawing.Point(12, 257);
            this.file_path_label.Name = "file_path_label";
            this.file_path_label.Size = new System.Drawing.Size(58, 21);
            this.file_path_label.TabIndex = 5;
            this.file_path_label.Text = "경로 : ";
            this.file_path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenFile_Dialog
            // 
            this.OpenFile_Dialog.FileName = "openFileDialog1";
            this.OpenFile_Dialog.Filter = "구성설정파일 (*.ini)|*.ini";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "default \'ping based\'",
            "eus     \'us east\'",
            "cus     \'us central\'",
            "scus    \'us south central\'",
            "wus     \'us west\'",
            "sbr     \'brazil south\'",
            "neu     \'europe north\'",
            "weu     \'europe west\'",
            "eas     \'asia east\'",
            "seas    \'asia south east\'",
            "eau     \'australia east\'",
            "wja     \'japan west\'"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selected_server
            // 
            this.selected_server.AutoSize = true;
            this.selected_server.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selected_server.Location = new System.Drawing.Point(478, 97);
            this.selected_server.Name = "selected_server";
            this.selected_server.Size = new System.Drawing.Size(16, 21);
            this.selected_server.TabIndex = 7;
            this.selected_server.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.selected_server);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.file_path_label);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.server_label);
            this.Controls.Add(this.select_server);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "레인보우식스시즈 서버 체인저";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_server;
        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Button file_path;
        private System.Windows.Forms.Label file_path_label;
        private System.Windows.Forms.OpenFileDialog OpenFile_Dialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selected_server;
    }
}

