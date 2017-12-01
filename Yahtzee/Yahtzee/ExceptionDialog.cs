using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class ExceptionDialog : Form
    {
        private int _tSeconds;
        public ExceptionDialog(Exception e)
        {
            InitializeComponent();

            string year = DateTime.Today.Year.ToString("D2"),
                   month = DateTime.Today.Month.ToString("D2"),
                   day = DateTime.Today.Day.ToString("D2"),
                   hour = DateTime.Now.Hour.ToString("D2"),
                   minute = DateTime.Now.Minute.ToString("D2"),
                   second = DateTime.Now.Second.ToString("D2");

            FileSystem fs = new FileSystem();
            System.IO.Directory.CreateDirectory(fs.AppDir + "\\logs");
            System.IO.File.WriteAllText(fs.AppDir + "\\logs\\errorlog" + year + month + day + hour + minute + second + ".txt", e.ToString());

            _tSeconds = 20;

            string appName = Assembly.GetExecutingAssembly().GetName().Name;

            Text = Text.Replace("$APP_NAME", appName);
            lblHeader.Text = lblHeader.Text.Replace("$APP_NAME", appName);
            UpdateTimer();

            txtErrorMessage.Text = e.ToString();

            timer.Enabled = true;
            timer.Start();
        }

        private void UpdateTimer()
        {
            btnRestart.Text = "&Restart" + (timer.Enabled ? " (" + _tSeconds.ToString() + "s)" : "");
        }

        private void chkAutoRestart_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = chkAutoRestart.Checked;
            UpdateTimer();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _tSeconds--;
            UpdateTimer();

            if (_tSeconds == 0) btnRestart.PerformClick();
        }
    }
}
