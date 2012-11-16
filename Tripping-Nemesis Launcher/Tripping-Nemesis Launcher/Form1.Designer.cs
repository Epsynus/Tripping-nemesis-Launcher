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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveLogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RestartDeadServerCheckBox = new System.Windows.Forms.CheckBox();
            this.MonitorCPUUsageCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RestartDeadServerNumeric = new System.Windows.Forms.NumericUpDown();
            this.MonitorCPUUsageNumeric = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestartDeadServerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorCPUUsageNumeric)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveCheckBox);
            this.groupBox1.Controls.Add(this.SaveLogButton);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonitorCPUUsageNumeric);
            this.groupBox2.Controls.Add(this.RestartDeadServerNumeric);
            this.groupBox2.Controls.Add(this.MonitorCPUUsageCheckBox);
            this.groupBox2.Controls.Add(this.RestartDeadServerCheckBox);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(252, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 283);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server not found.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(2, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Server";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(3, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Character Server";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(1, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 80);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Map Server";
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
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(6, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Priority";
            this.button4.UseVisualStyleBackColor = true;
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
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(6, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Priority";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Start";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server not found.";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(8, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Priority";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(57, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(8, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Start";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Server not found.";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestartDeadServerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorCPUUsageNumeric)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveLogButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox SaveCheckBox;
    }
}

