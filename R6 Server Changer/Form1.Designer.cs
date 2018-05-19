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
            this.file_path = new System.Windows.Forms.Button();
            this.OpenFile_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selected_server = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.help_btn = new System.Windows.Forms.Button();
            this.search_player = new System.Windows.Forms.Button();
            this.player_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kill_label = new System.Windows.Forms.Label();
            this.killed_n = new System.Windows.Forms.Label();
            this.death_n = new System.Windows.Forms.Label();
            this.death_label = new System.Windows.Forms.Label();
            this.kill_death_n = new System.Windows.Forms.Label();
            this.KillDeath_label = new System.Windows.Forms.Label();
            this.level_n = new System.Windows.Forms.Label();
            this.level_label = new System.Windows.Forms.Label();
            this.win_n = new System.Windows.Forms.Label();
            this.win_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_server
            // 
            this.select_server.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_server.Location = new System.Drawing.Point(12, 75);
            this.select_server.Name = "select_server";
            this.select_server.Size = new System.Drawing.Size(292, 47);
            this.select_server.TabIndex = 0;
            this.select_server.Text = "서버 변경 확인";
            this.select_server.UseVisualStyleBackColor = true;
            this.select_server.Click += new System.EventHandler(this.select_server_Click);
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_label.Location = new System.Drawing.Point(310, 41);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(114, 23);
            this.server_label.TabIndex = 2;
            this.server_label.Text = "선택된 서버 : ";
            this.server_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // file_path
            // 
            this.file_path.Font = new System.Drawing.Font("굴림", 10F);
            this.file_path.Location = new System.Drawing.Point(314, 75);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(196, 47);
            this.file_path.TabIndex = 4;
            this.file_path.Text = "파일선택";
            this.file_path.UseVisualStyleBackColor = true;
            this.file_path.Click += new System.EventHandler(this.file_path_Click);
            // 
            // OpenFile_Dialog
            // 
            this.OpenFile_Dialog.FileName = "openFileDialog1";
            this.OpenFile_Dialog.Filter = "구성설정파일 (*.ini)|*.ini";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selected_server
            // 
            this.selected_server.AutoSize = true;
            this.selected_server.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selected_server.Location = new System.Drawing.Point(478, 89);
            this.selected_server.Name = "selected_server";
            this.selected_server.Size = new System.Drawing.Size(16, 21);
            this.selected_server.TabIndex = 7;
            this.selected_server.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "서버선택";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.win_n);
            this.groupBox1.Controls.Add(this.win_label);
            this.groupBox1.Controls.Add(this.level_n);
            this.groupBox1.Controls.Add(this.level_label);
            this.groupBox1.Controls.Add(this.kill_death_n);
            this.groupBox1.Controls.Add(this.KillDeath_label);
            this.groupBox1.Controls.Add(this.death_n);
            this.groupBox1.Controls.Add(this.death_label);
            this.groupBox1.Controls.Add(this.killed_n);
            this.groupBox1.Controls.Add(this.kill_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.player_name);
            this.groupBox1.Controls.Add(this.search_player);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "간단 전적 uplay만 검색 가능합니다";
            // 
            // help_btn
            // 
            this.help_btn.Location = new System.Drawing.Point(314, 8);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(196, 23);
            this.help_btn.TabIndex = 10;
            this.help_btn.Text = "사용법";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // search_player
            // 
            this.search_player.Location = new System.Drawing.Point(303, 25);
            this.search_player.Name = "search_player";
            this.search_player.Size = new System.Drawing.Size(183, 26);
            this.search_player.TabIndex = 0;
            this.search_player.Text = "전적검색";
            this.search_player.UseVisualStyleBackColor = true;
            this.search_player.Click += new System.EventHandler(this.search_player_Click);
            // 
            // player_name
            // 
            this.player_name.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.player_name.Location = new System.Drawing.Point(70, 25);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(227, 29);
            this.player_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "이름 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kill_label
            // 
            this.kill_label.AutoSize = true;
            this.kill_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kill_label.Location = new System.Drawing.Point(14, 61);
            this.kill_label.Name = "kill_label";
            this.kill_label.Size = new System.Drawing.Size(40, 21);
            this.kill_label.TabIndex = 12;
            this.kill_label.Text = "킬 : ";
            // 
            // killed_n
            // 
            this.killed_n.AutoSize = true;
            this.killed_n.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.killed_n.Location = new System.Drawing.Point(52, 61);
            this.killed_n.Name = "killed_n";
            this.killed_n.Size = new System.Drawing.Size(79, 21);
            this.killed_n.TabIndex = 13;
            this.killed_n.Text = "결과 없음";
            // 
            // death_n
            // 
            this.death_n.AutoSize = true;
            this.death_n.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.death_n.Location = new System.Drawing.Point(210, 61);
            this.death_n.Name = "death_n";
            this.death_n.Size = new System.Drawing.Size(79, 21);
            this.death_n.TabIndex = 15;
            this.death_n.Text = "결과 없음";
            // 
            // death_label
            // 
            this.death_label.AutoSize = true;
            this.death_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.death_label.Location = new System.Drawing.Point(149, 61);
            this.death_label.Name = "death_label";
            this.death_label.Size = new System.Drawing.Size(56, 21);
            this.death_label.TabIndex = 14;
            this.death_label.Text = "죽음 : ";
            // 
            // kill_death_n
            // 
            this.kill_death_n.AutoSize = true;
            this.kill_death_n.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kill_death_n.Location = new System.Drawing.Point(399, 61);
            this.kill_death_n.Name = "kill_death_n";
            this.kill_death_n.Size = new System.Drawing.Size(79, 21);
            this.kill_death_n.TabIndex = 17;
            this.kill_death_n.Text = "결과 없음";
            // 
            // KillDeath_label
            // 
            this.KillDeath_label.AutoSize = true;
            this.KillDeath_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KillDeath_label.Location = new System.Drawing.Point(319, 61);
            this.KillDeath_label.Name = "KillDeath_label";
            this.KillDeath_label.Size = new System.Drawing.Size(78, 21);
            this.KillDeath_label.TabIndex = 16;
            this.KillDeath_label.Text = "킬/데스 : ";
            // 
            // level_n
            // 
            this.level_n.AutoSize = true;
            this.level_n.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_n.Location = new System.Drawing.Point(75, 93);
            this.level_n.Name = "level_n";
            this.level_n.Size = new System.Drawing.Size(79, 21);
            this.level_n.TabIndex = 19;
            this.level_n.Text = "결과 없음";
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_label.Location = new System.Drawing.Point(14, 93);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(56, 21);
            this.level_label.TabIndex = 18;
            this.level_label.Text = "레벨 : ";
            // 
            // win_n
            // 
            this.win_n.AutoSize = true;
            this.win_n.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.win_n.Location = new System.Drawing.Point(231, 93);
            this.win_n.Name = "win_n";
            this.win_n.Size = new System.Drawing.Size(79, 21);
            this.win_n.TabIndex = 21;
            this.win_n.Text = "결과 없음";
            // 
            // win_label
            // 
            this.win_label.AutoSize = true;
            this.win_label.Font = new System.Drawing.Font("맑은 고딕 Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.win_label.Location = new System.Drawing.Point(169, 93);
            this.win_label.Name = "win_label";
            this.win_label.Size = new System.Drawing.Size(56, 21);
            this.win_label.TabIndex = 20;
            this.win_label.Text = "승률 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 263);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selected_server);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.server_label);
            this.Controls.Add(this.select_server);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "레인보우식스시즈 서버 체인저";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_server;
        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.Button file_path;
        private System.Windows.Forms.OpenFileDialog OpenFile_Dialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selected_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player_name;
        private System.Windows.Forms.Button search_player;
        private System.Windows.Forms.Label kill_label;
        private System.Windows.Forms.Label killed_n;
        private System.Windows.Forms.Label death_n;
        private System.Windows.Forms.Label death_label;
        private System.Windows.Forms.Label kill_death_n;
        private System.Windows.Forms.Label KillDeath_label;
        private System.Windows.Forms.Label level_n;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label win_n;
        private System.Windows.Forms.Label win_label;
    }
}

