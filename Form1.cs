using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region SCHEDULE SHUTDOWN
        private void ScheduleShutdown(int hours)
        {
            int seconds = hours * 3600;

            Process cmd = new Process();
            cmd.StartInfo.FileName = "shutdown.exe";
            cmd.StartInfo.Arguments = $"/s /f /t {seconds}";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            richTextBox1.AppendText($"O Systém bude vypnut za {hours} hodinu/hodin.\n");
        }
        #endregion

        #region STOP SHUTDOWN
        private void btnStop_Click(object sender, EventArgs e)
        {
            Process stopCmd = new Process();
            stopCmd.StartInfo.FileName = "shutdown.exe";
            stopCmd.StartInfo.Arguments = "/a";
            stopCmd.StartInfo.CreateNoWindow = true;
            stopCmd.StartInfo.UseShellExecute = false;

            stopCmd.Start();

            richTextBox1.AppendText("X Naplánované vypnutí bylo zrušeno.\n");
        }
        #endregion

        #region BUTTON EVENTS
        private void btn1h_Click(object sender, EventArgs e)
        {
            ScheduleShutdown(1);
        }

        private void btn2h_Click(object sender, EventArgs e)
        {
            ScheduleShutdown(2);
        }

        private void btn3h_Click(object sender, EventArgs e)
        {
            ScheduleShutdown(3);
        }

        private void btn4h_Click(object sender, EventArgs e)
        {
            ScheduleShutdown(4);
        }
        #endregion

    }
}
