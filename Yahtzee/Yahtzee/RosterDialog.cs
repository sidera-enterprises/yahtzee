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
    public partial class RosterDialog : Form
    {
        private FileSystem _fs;
        private const int _MAX_PLAYERS = 4,
                          _MAX_CHAR_LENGTH = 15;
        private const string _ROSTER_CFG_FN = "roster.txt";
        public RosterDialog()
        {
            InitializeComponent();

            _fs = new FileSystem();

            if (_fs.ConfigFileExists(_ROSTER_CFG_FN))
            {
                string rosterContent = _fs.ReadConfigFile(_ROSTER_CFG_FN);
                string[] lines = rosterContent.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (line.Contains(':'))
                    {
                        string[] pieces = line.Split(':');

                        string name = pieces[0].Trim(),
                               type = pieces[1].Trim();

                        if (name.Length > _MAX_CHAR_LENGTH) name = name.Substring(0, _MAX_CHAR_LENGTH);

                        AddPlayer(name, type.ToLower() == "player");
                    }
                }
            }

            lstRoster.Scrollable = false;
            lblAppVersion.Text = "v" + AppVersionInfo.VersionMajorMinorBuild;
        }

        public string[] Players
        {
            get
            {
                string[] s = new string[lstRoster.Items.Count];
                for (int i = 0; i < lstRoster.Items.Count; i++)
                    s[i] = lstRoster.Items[i].Text;

                return s;
            }
        }

        public bool Contains(string player, bool ignoreCase)
        {
            string[] roster = Players;
            string query = ignoreCase ? player.ToUpper() : player;

            if (ignoreCase)
            {
                for (int i = 0; i < roster.Length; i++)
                    roster[i] = roster[i].ToUpper();
            }

            return roster.Contains(query);
        }

        public bool AddPlayer(string name)
        {
            return AddPlayer(name, true);
        }

        public bool AddPlayer(string name, bool human)
        {
            bool canAdd = Players.Length < _MAX_PLAYERS;

            if (canAdd)
            {
                ImageList i = new ImageList();
                i.ImageSize = new Size(32, 32);
                i.Images.Add("player", Properties.Resources.Player);
                i.Images.Add("robot", Properties.Resources.Robot);
                lstRoster.LargeImageList = i;

                ListViewItem l = lstRoster.Items.Add(name);
                l.ImageKey = human ? "player" : "robot";
            }

            return canAdd;
        }

        private void roster_PlayerCountChanged(object sender, EventArgs e)
        {

            //btnAdd.Enabled = roster.CanAddPlayer;
            //lblPlayerCount.Text = roster.PlayerCount + ((roster.PlayerCount == 1) ? " player"
            //                                                                      : " players");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*roster.AddPlayer();
            roster.Focus();
            roster.Select();*/
            TextInputDialog t = new TextInputDialog("Enter player's name:", _MAX_CHAR_LENGTH);
            DialogResult dr = t.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (!Contains(t.Text, true))
                {
                    if (t.Text.Contains(':'))
                    {
                        MessageBox.Show("The player's name cannot contain the character"
                                      + " \":\".",
                                        "",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else AddPlayer(t.Text);
                }
                else
                {
                    MessageBox.Show("A player named '" + t.Text + "' is already listed"
                                  + " in the roster. Please use a unique name.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void lstRoster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                mnuDelete.PerformClick();
        }

        private void lstRoster_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem l = lstRoster.FocusedItem;
                if (l.Bounds.Contains(e.Location)) mnuContextMenu.Show(Cursor.Position);
            }
        }

        private void lstRoster_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mnuRename.PerformClick();
        }

        private void lstRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuRename.Visible = lstRoster.SelectedItems.Count == 1;
        }

        private void mnuRename_Click(object sender, EventArgs e)
        {
            if (lstRoster.SelectedItems.Count == 1)
            {
                ListViewItem l = lstRoster.SelectedItems[0];
                TextInputDialog t = new TextInputDialog("Change player's name:", l.Text, _MAX_CHAR_LENGTH);
                DialogResult dr = t.ShowDialog();

                if (dr == DialogResult.OK) l.Text = t.Text;
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lstRoster.SelectedItems)
                l.Remove();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (!_fs.AppFileExists("help.html"))
                _fs.WriteFile("help.html", Properties.Resources.HelpManual);

            System.Diagnostics.Process.Start(_fs.AppDir + "\\help.html");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Concatenate names into a human-readable list
            string[] names = new string[Players.Length];
            string sNames = "";
            for (int i = 0; i < lstRoster.Items.Count; i++)
                names[i] = lstRoster.Items[i].Text;

            if (names.Length == 1)
                sNames = names[0];
            else if (names.Length == 2)
                sNames = names[0] + " and " + names[1];
            else
            {
                for (int i = 0; i < names.Length - 1; i++)
                    sNames += names[i] + ", ";

                sNames += "and " + names[names.Length - 1];
            }

            // Save roster configuration
            string configContent = "";
            for (int i = 0; i < names.Length; i++)
            {
                configContent += names[i] + " : " + lstRoster.Items[i].ImageKey;
                if (i < names.Length - 1) configContent += "\r\n";
            }
            _fs.WriteConfigFile(_ROSTER_CFG_FN, configContent);

            lblAppVersion.Text = "Generating score sheet for " + sNames + " ...";
            Cursor = Cursors.WaitCursor;
            Enabled = false;

            //SplashScreenForm s = new SplashScreenForm(5,
            //                                          "Generating score sheet for "
            //                                        + sNames + ", please wait...");
            //s.Show(); // Splash screen will hide itself

            MainForm f = new MainForm(names);
            Hide();
            f.ShowDialog();
            if (!Program.HasExited)
            {
                Show();

                lblAppVersion.Text = "v" + AppVersionInfo.VersionMajorMinorBuild;
                Cursor = Cursors.Default;
                Enabled = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int count = lstRoster.Items.Count;

            lblPlayerCount.Text = count + " player" + (count == 1 ? "" : "s");
            btnAdd.Enabled = count < _MAX_PLAYERS;
            btnPlay.Enabled = count > 0;
        }
    }
}
