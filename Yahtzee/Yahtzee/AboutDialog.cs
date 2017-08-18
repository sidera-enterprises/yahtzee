using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class AboutDialog : Form
    {
        private Version _version;
        private int _major, _minor, _build;

        public AboutDialog()
        {
            InitializeComponent();

            _version = Assembly.GetExecutingAssembly().GetName().Version;
            _major = _version.Major;
            _minor = _version.Minor;
            _build = _version.Build;
            
            lblAppVersion.Text = lblAppVersion.Text.Replace("v*.*",
                                                            "v" + _major + "." + _minor
                                                          + " beta build " + _build);

            btnClose.Select();
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sidera-enterprises/yahtzee");
        }

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseDialog l = new LicenseDialog();
            l.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkCheckUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text;
            try
            {
                WebClient wc = new WebClient();
                Stream s = wc.OpenRead("https://sidera.neocities.org/downloads/yahtzee/ver.txt");
                StreamReader sr = new StreamReader(s);

                text = sr.ReadToEnd();
            } catch { text = "0"; }

            double currentBuild = Double.Parse(_major + "." + _minor),
                   latestBuild = Double.Parse(text);

            // Check if available build is newer than current build
            if (latestBuild > currentBuild)
            {
                DialogResult dr = MessageBox.Show("A new version of this application is "
                                                + "available. Would you like to download "
                                                + "it now?",
                                                  "New Update Available",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                    Process.Start("https://sidera.neocities.org/downloads/yahtzee/");
            }
            else
            {
                MessageBox.Show("No updates are available for this software at this time. "
                              + "Please try again later.",
                                "No Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
