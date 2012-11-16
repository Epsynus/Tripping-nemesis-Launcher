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
            if (SaveCheckBox.Checked == true)
                SaveLogButton.Enabled = true;
            else
                SaveLogButton.Enabled = false;
        }

        private void RestartDeadServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RestartDeadServerCheckBox.Checked == false)
                RestartDeadServerNumeric.Enabled = false;
            else
                RestartDeadServerNumeric.Enabled = true;
        }

        private void MonitorCPUUsageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MonitorCPUUsageCheckBox.Checked == false)
                MonitorCPUUsageNumeric.Enabled = false;
            else
                MonitorCPUUsageNumeric.Enabled = true;
        }
    }
}
