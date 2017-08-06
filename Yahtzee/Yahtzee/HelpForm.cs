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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            webHelpDoc.DocumentText = Properties.Resources.Help;
        }

        private void mnuFile_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            AboutDialog d = new AboutDialog();
            d.ShowDialog();
        }
    }
}
