namespace Tripping_Nemesis_Launcher
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MonitorCPUUsageNumeric = new System.Windows.Forms.NumericUpDown();
            this.RestartDeadServerNumeric = new System.Windows.Forms.NumericUpDown();
            this.MonitorCPUUsageCheckBox = new System.Windows.Forms.CheckBox();
            this.RestartDeadServerCheckBox = new System.Windows.Forms.CheckBox();
            this.MapGroupBox = new System.Windows.Forms.GroupBox();
            this.SetMapServerPriority = new System.Windows.Forms.Button();
            this.StartMapServerExeButton = new System.Windows.Forms.Button();
            this.selectMapServerExeButton = new System.Windows.Forms.Button();
            this.MapLabel = new System.Windows.Forms.Label();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.SetCharServerPriority = new System.Windows.Forms.Button();
            this.StartCharServerExeButton = new System.Windows.Forms.Button();
            this.selectCharServerExeButton = new System.Windows.Forms.Button();
            this.CharLabel = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.SetLoginServerPriority = new System.Windows.Forms.Button();
            this.selectLoginServerExeButton = new System.Windows.Forms.Button();
            this.StartLoginServerExeButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveLogButton = new System.Windows.Forms.Button();
            this.ServerHistoryLog = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openLoginServerexeDialog = new System.Windows.Forms.OpenFileDialog();
            this.openCharServerexeDialog = new System.Windows.Forms.OpenFileDialog();
            this.openMapServerexeDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorCPUUsageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartDeadServerNumeric)).BeginInit();
            this.MapGroupBox.SuspendLayout();
            this.CharacterGroupBox.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonitorCPUUsageNumeric);
            this.groupBox2.Controls.Add(this.RestartDeadServerNumeric);
            this.groupBox2.Controls.Add(this.MonitorCPUUsageCheckBox);
            this.groupBox2.Controls.Add(this.RestartDeadServerCheckBox);
            this.groupBox2.Controls.Add(this.MapGroupBox);
            this.groupBox2.Controls.Add(this.CharacterGroupBox);
            this.groupBox2.Controls.Add(this.LoginGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(252, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers";
            // 
            // MonitorCPUUsageNumeric
            // 
            this.MonitorCPUUsageNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MonitorCPUUsageNumeric.Location = new System.Drawing.Point(178, 41);
            this.MonitorCPUUsageNumeric.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.MonitorCPUUsageNumeric.Name = "MonitorCPUUsageNumeric";
            this.MonitorCPUUsageNumeric.Size = new System.Drawing.Size(57, 20);
            this.MonitorCPUUsageNumeric.TabIndex = 9;
            this.MonitorCPUUsageNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RestartDeadServerNumeric
            // 
            this.RestartDeadServerNumeric.Location = new System.Drawing.Point(178, 19);
            this.RestartDeadServerNumeric.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.RestartDeadServerNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RestartDeadServerNumeric.Name = "RestartDeadServerNumeric";
            this.RestartDeadServerNumeric.Size = new System.Drawing.Size(57, 20);
            this.RestartDeadServerNumeric.TabIndex = 8;
            this.RestartDeadServerNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // MonitorCPUUsageCheckBox
            // 
            this.MonitorCPUUsageCheckBox.AutoSize = true;
            this.MonitorCPUUsageCheckBox.Checked = true;
            this.MonitorCPUUsageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MonitorCPUUsageCheckBox.Location = new System.Drawing.Point(23, 44);
            this.MonitorCPUUsageCheckBox.Name = "MonitorCPUUsageCheckBox";
            this.MonitorCPUUsageCheckBox.Size = new System.Drawing.Size(145, 17);
            this.MonitorCPUUsageCheckBox.TabIndex = 7;
            this.MonitorCPUUsageCheckBox.Text = "Monitor CPU Usage (mm)";
            this.MonitorCPUUsageCheckBox.UseVisualStyleBackColor = true;
            this.MonitorCPUUsageCheckBox.CheckedChanged += new System.EventHandler(this.MonitorCPUUsageCheckBox_CheckedChanged);
            // 
            // RestartDeadServerCheckBox
            // 
            this.RestartDeadServerCheckBox.AutoSize = true;
            this.RestartDeadServerCheckBox.Checked = true;
            this.RestartDeadServerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RestartDeadServerCheckBox.Location = new System.Drawing.Point(23, 21);
            this.RestartDeadServerCheckBox.Name = "RestartDeadServerCheckBox";
            this.RestartDeadServerCheckBox.Size = new System.Drawing.Size(149, 17);
            this.RestartDeadServerCheckBox.TabIndex = 6;
            this.RestartDeadServerCheckBox.Text = "Restart Dead Server (sec)";
            this.RestartDeadServerCheckBox.UseVisualStyleBackColor = true;
            this.RestartDeadServerCheckBox.CheckedChanged += new System.EventHandler(this.RestartDeadServerCheckBox_CheckedChanged);
            // 
            // MapGroupBox
            // 
            this.MapGroupBox.Controls.Add(this.SetMapServerPriority);
            this.MapGroupBox.Controls.Add(this.StartMapServerExeButton);
            this.MapGroupBox.Controls.Add(this.selectMapServerExeButton);
            this.MapGroupBox.Controls.Add(this.MapLabel);
            this.MapGroupBox.Location = new System.Drawing.Point(1, 249);
            this.MapGroupBox.Name = "MapGroupBox";
            this.MapGroupBox.Size = new System.Drawing.Size(333, 80);
            this.MapGroupBox.TabIndex = 3;
            this.MapGroupBox.TabStop = false;
            this.MapGroupBox.Text = "Map Server";
            // 
            // SetMapServerPriority
            // 
            this.SetMapServerPriority.Enabled = false;
            this.SetMapServerPriority.Location = new System.Drawing.Point(8, 46);
            this.SetMapServerPriority.Name = "SetMapServerPriority";
            this.SetMapServerPriority.Size = new System.Drawing.Size(75, 23);
            this.SetMapServerPriority.TabIndex = 16;
            this.SetMapServerPriority.Text = "Priority";
            this.SetMapServerPriority.UseVisualStyleBackColor = true;
            this.SetMapServerPriority.Click += new System.EventHandler(this.SetMapServerPriority_Click);
            // 
            // StartMapServerExeButton
            // 
            this.StartMapServerExeButton.Enabled = false;
            this.StartMapServerExeButton.Location = new System.Drawing.Point(8, 19);
            this.StartMapServerExeButton.Name = "StartMapServerExeButton";
            this.StartMapServerExeButton.Size = new System.Drawing.Size(50, 23);
            this.StartMapServerExeButton.TabIndex = 14;
            this.StartMapServerExeButton.Text = "Start";
            this.StartMapServerExeButton.UseVisualStyleBackColor = true;
            this.StartMapServerExeButton.Click += new System.EventHandler(this.StartMapServerExeButton_Click);
            // 
            // selectMapServerExeButton
            // 
            this.selectMapServerExeButton.Location = new System.Drawing.Point(57, 19);
            this.selectMapServerExeButton.Name = "selectMapServerExeButton";
            this.selectMapServerExeButton.Size = new System.Drawing.Size(27, 23);
            this.selectMapServerExeButton.TabIndex = 15;
            this.selectMapServerExeButton.Text = "...";
            this.selectMapServerExeButton.UseVisualStyleBackColor = true;
            this.selectMapServerExeButton.Click += new System.EventHandler(this.selectMapServerExeButton_Click);
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Location = new System.Drawing.Point(97, 24);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(89, 13);
            this.MapLabel.TabIndex = 13;
            this.MapLabel.Text = "Server not found.";
            // 
            // CharacterGroupBox
            // 
            this.CharacterGroupBox.Controls.Add(this.SetCharServerPriority);
            this.CharacterGroupBox.Controls.Add(this.StartCharServerExeButton);
            this.CharacterGroupBox.Controls.Add(this.selectCharServerExeButton);
            this.CharacterGroupBox.Controls.Add(this.CharLabel);
            this.CharacterGroupBox.Location = new System.Drawing.Point(3, 157);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(333, 86);
            this.CharacterGroupBox.TabIndex = 3;
            this.CharacterGroupBox.TabStop = false;
            this.CharacterGroupBox.Text = "Character Server";
            // 
            // SetCharServerPriority
            // 
            this.SetCharServerPriority.Enabled = false;
            this.SetCharServerPriority.Location = new System.Drawing.Point(6, 46);
            this.SetCharServerPriority.Name = "SetCharServerPriority";
            this.SetCharServerPriority.Size = new System.Drawing.Size(75, 23);
            this.SetCharServerPriority.TabIndex = 12;
            this.SetCharServerPriority.Text = "Priority";
            this.SetCharServerPriority.UseVisualStyleBackColor = true;
            this.SetCharServerPriority.Click += new System.EventHandler(this.SetCharServerPriority_Click);
            // 
            // StartCharServerExeButton
            // 
            this.StartCharServerExeButton.Enabled = false;
            this.StartCharServerExeButton.Location = new System.Drawing.Point(6, 19);
            this.StartCharServerExeButton.Name = "StartCharServerExeButton";
            this.StartCharServerExeButton.Size = new System.Drawing.Size(50, 23);
            this.StartCharServerExeButton.TabIndex = 10;
            this.StartCharServerExeButton.Text = "Start";
            this.StartCharServerExeButton.UseVisualStyleBackColor = true;
            this.StartCharServerExeButton.Click += new System.EventHandler(this.StartCharServerExeButton_Click);
            // 
            // selectCharServerExeButton
            // 
            this.selectCharServerExeButton.Location = new System.Drawing.Point(55, 19);
            this.selectCharServerExeButton.Name = "selectCharServerExeButton";
            this.selectCharServerExeButton.Size = new System.Drawing.Size(27, 23);
            this.selectCharServerExeButton.TabIndex = 11;
            this.selectCharServerExeButton.Text = "...";
            this.selectCharServerExeButton.UseVisualStyleBackColor = true;
            this.selectCharServerExeButton.Click += new System.EventHandler(this.selectCharServerExeButton_Click);
            // 
            // CharLabel
            // 
            this.CharLabel.AutoSize = true;
            this.CharLabel.Location = new System.Drawing.Point(95, 24);
            this.CharLabel.Name = "CharLabel";
            this.CharLabel.Size = new System.Drawing.Size(89, 13);
            this.CharLabel.TabIndex = 9;
            this.CharLabel.Text = "Server not found.";
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.SetLoginServerPriority);
            this.LoginGroupBox.Controls.Add(this.selectLoginServerExeButton);
            this.LoginGroupBox.Controls.Add(this.StartLoginServerExeButton);
            this.LoginGroupBox.Controls.Add(this.LoginLabel);
            this.LoginGroupBox.Location = new System.Drawing.Point(2, 73);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(333, 78);
            this.LoginGroupBox.TabIndex = 2;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login Server";
            // 
            // SetLoginServerPriority
            // 
            this.SetLoginServerPriority.Enabled = false;
            this.SetLoginServerPriority.Location = new System.Drawing.Point(6, 45);
            this.SetLoginServerPriority.Name = "SetLoginServerPriority";
            this.SetLoginServerPriority.Size = new System.Drawing.Size(75, 23);
            this.SetLoginServerPriority.TabIndex = 8;
            this.SetLoginServerPriority.Text = "Priority";
            this.SetLoginServerPriority.UseVisualStyleBackColor = true;
            this.SetLoginServerPriority.Click += new System.EventHandler(this.SetLoginServerPriority_Click);
            // 
            // selectLoginServerExeButton
            // 
            this.selectLoginServerExeButton.Location = new System.Drawing.Point(55, 18);
            this.selectLoginServerExeButton.Name = "selectLoginServerExeButton";
            this.selectLoginServerExeButton.Size = new System.Drawing.Size(27, 23);
            this.selectLoginServerExeButton.TabIndex = 7;
            this.selectLoginServerExeButton.Text = "...";
            this.selectLoginServerExeButton.UseVisualStyleBackColor = true;
            this.selectLoginServerExeButton.Click += new System.EventHandler(this.selectLoginServerExeButton_Click);
            // 
            // StartLoginServerExeButton
            // 
            this.StartLoginServerExeButton.Enabled = false;
            this.StartLoginServerExeButton.Location = new System.Drawing.Point(6, 18);
            this.StartLoginServerExeButton.Name = "StartLoginServerExeButton";
            this.StartLoginServerExeButton.Size = new System.Drawing.Size(50, 23);
            this.StartLoginServerExeButton.TabIndex = 6;
            this.StartLoginServerExeButton.Text = "Start";
            this.StartLoginServerExeButton.UseVisualStyleBackColor = true;
            this.StartLoginServerExeButton.Click += new System.EventHandler(this.StartLoginServerExeButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(95, 23);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(89, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Server not found.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveCheckBox);
            this.groupBox1.Controls.Add(this.SaveLogButton);
            this.groupBox1.Controls.Add(this.ServerHistoryLog);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // SaveCheckBox
            // 
            this.SaveCheckBox.AutoSize = true;
            this.SaveCheckBox.Location = new System.Drawing.Point(112, 305);
            this.SaveCheckBox.Name = "SaveCheckBox";
            this.SaveCheckBox.Size = new System.Drawing.Size(51, 17);
            this.SaveCheckBox.TabIndex = 6;
            this.SaveCheckBox.Text = "Save";
            this.SaveCheckBox.UseVisualStyleBackColor = true;
            this.SaveCheckBox.CheckedChanged += new System.EventHandler(this.SaveCheckBox_CheckedChanged);
            // 
            // SaveLogButton
            // 
            this.SaveLogButton.Enabled = false;
            this.SaveLogButton.Location = new System.Drawing.Point(169, 301);
            this.SaveLogButton.Name = "SaveLogButton";
            this.SaveLogButton.Size = new System.Drawing.Size(53, 23);
            this.SaveLogButton.TabIndex = 3;
            this.SaveLogButton.Text = "...";
            this.SaveLogButton.UseVisualStyleBackColor = true;
            this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
            // 
            // ServerHistoryLog
            // 
            this.ServerHistoryLog.Location = new System.Drawing.Point(0, 19);
            this.ServerHistoryLog.Name = "ServerHistoryLog";
            this.ServerHistoryLog.Size = new System.Drawing.Size(222, 283);
            this.ServerHistoryLog.TabIndex = 2;
            this.ServerHistoryLog.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(591, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Character Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(591, 355);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Map Server";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // saveLogFileDialog
            // 
            this.saveLogFileDialog.DefaultExt = "log";
            this.saveLogFileDialog.Filter = "Log File (*.log)|*.log";
            // 
            // openLoginServerexeDialog
            // 
            this.openLoginServerexeDialog.FileName = "login-server_sql";
            this.openLoginServerexeDialog.Filter = "Executable(*.exe)|*.exe";
            // 
            // openCharServerexeDialog
            // 
            this.openCharServerexeDialog.FileName = "char-server_sql";
            this.openCharServerexeDialog.Filter = "Executable(*.exe)|*.exe";
            // 
            // openMapServerexeDialog
            // 
            this.openMapServerexeDialog.FileName = "map-server_sql";
            this.openMapServerexeDialog.Filter = "Executable(*.exe)|*.exe";
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "LauncherForm";
            this.Text = "Tripping Nemesis Launcher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorCPUUsageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartDeadServerNumeric)).EndInit();
            this.MapGroupBox.ResumeLayout(false);
            this.MapGroupBox.PerformLayout();
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown MonitorCPUUsageNumeric;
        private System.Windows.Forms.NumericUpDown RestartDeadServerNumeric;
        private System.Windows.Forms.CheckBox MonitorCPUUsageCheckBox;
        private System.Windows.Forms.CheckBox RestartDeadServerCheckBox;
        private System.Windows.Forms.GroupBox MapGroupBox;
        private System.Windows.Forms.Button SetMapServerPriority;
        private System.Windows.Forms.Button StartMapServerExeButton;
        private System.Windows.Forms.Button selectMapServerExeButton;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.Button SetCharServerPriority;
        private System.Windows.Forms.Button StartCharServerExeButton;
        private System.Windows.Forms.Button selectCharServerExeButton;
        private System.Windows.Forms.Label CharLabel;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button SetLoginServerPriority;
        private System.Windows.Forms.Button selectLoginServerExeButton;
        private System.Windows.Forms.Button StartLoginServerExeButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveLogButton;
        private System.Windows.Forms.RichTextBox ServerHistoryLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox SaveCheckBox;
        private System.Windows.Forms.SaveFileDialog saveLogFileDialog;
        private System.Windows.Forms.OpenFileDialog openLoginServerexeDialog;
        private System.Windows.Forms.OpenFileDialog openCharServerexeDialog;
        private System.Windows.Forms.OpenFileDialog openMapServerexeDialog;
    }
}

