using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripping_Nemesis_Launcher
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void SaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the save checkbox is checked it will enable the button to select where to save, else it will keep the button disabled
            if (SaveCheckBox.Checked == true)
                SaveLogButton.Enabled = true;
            else
                SaveLogButton.Enabled = false;
        }

        private void RestartDeadServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the Restart dead server check box is checked it will allow you to choose how long it will take before it will automatically restart incase it crashes
            if (RestartDeadServerCheckBox.Checked == false)
                RestartDeadServerNumeric.Enabled = false;
            else
                RestartDeadServerNumeric.Enabled = true;
        }

        private void MonitorCPUUsageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the Monitor CPU Usage checkbox is checked it will allow you to choose the interval at which it will check and report the CPU usage that the server has at that current time.
            if (MonitorCPUUsageCheckBox.Checked == false)
                MonitorCPUUsageNumeric.Enabled = false;
            else
                MonitorCPUUsageNumeric.Enabled = true;
        }

        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            //saves the server logfile as a plain text document with the .log extension, if they press cancel or saves the file it unticks the checkbox.
            // as well as clears the log window
            if (saveLogFileDialog.ShowDialog() == DialogResult.OK)
            {
                ServerHistoryLog.SaveFile(saveLogFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    SaveCheckBox.Checked = false;
                    ServerHistoryLog.Text = "";
            }
            else
            {
                SaveCheckBox.Checked = false;
            }
        }
        private void selectLoginServerExeButton_Click(object sender, EventArgs e)
        {
            if (openLoginServerexeDialog.ShowDialog() == DialogResult.OK)
            {
                //Do stuff
                StartLoginServerExeButton.Enabled = true;
                SetLoginServerPriority.Enabled = true;
                LoginLabel.Text = "Server Ready.";
                LoginGroupBox.Text = "Login Server: " + openLoginServerexeDialog.SafeFileName;
            }
        }

        private void selectCharServerExeButton_Click(object sender, EventArgs e)
        {
            if (openCharServerexeDialog.ShowDialog() == DialogResult.OK)
            {
                //do stuff
                StartCharServerExeButton.Enabled = true;
                SetCharServerPriority.Enabled = true;
                CharLabel.Text = "Server Ready.";
                CharacterGroupBox.Text = "Character Server: " + openCharServerexeDialog.SafeFileName;
            }
        }

        private void selectMapServerExeButton_Click(object sender, EventArgs e)
        {
            if (openMapServerexeDialog.ShowDialog() == DialogResult.OK)
            {
                //do stuff
                StartMapServerExeButton.Enabled = true;
                SetMapServerPriority.Enabled = true;
                MapLabel.Text = "Server Ready.";
                MapGroupBox.Text = "Map Server: " + openMapServerexeDialog.SafeFileName;
            }
        }
    }
}
