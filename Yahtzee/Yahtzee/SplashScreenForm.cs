using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class SplashScreenForm : Form
    {
        private Timer _timer;
        private int _secElapsed, _delayConfig;
        private Form _form;
        public SplashScreenForm(string subtitle) : this(null, subtitle) { }
        public SplashScreenForm(int delay, string subtitle) : this(delay, null, subtitle) { }
        public SplashScreenForm(Form form, string subtitle) : this(0, form, subtitle) { }
        public SplashScreenForm(int delay, Form form, string subtitle)
        {
            InitializeComponent();

            Cursor = Cursors.WaitCursor;
            
            _secElapsed = 0;
            _delayConfig = delay;
            lblSubtitle.Text = subtitle;

            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _timer.Enabled = true;
            _timer.Interval = 1000;
            _timer.Start();

            _form = form;
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            if (_delayConfig == 0)
            {
                Hide();
                if (_form != null)
                {
                    _form.ShowDialog();
                    Close();
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_secElapsed < _delayConfig) _secElapsed++;
            else
            {
                _timer.Stop();

                Hide();
                if (_form != null)
                {
                    _form.ShowDialog();
                    Close();
                }
            }
        }
    }
}
