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
    public partial class StartupDialog : Form
    {
        private const int _MAX_PLAYERS = 10;
        public StartupDialog()
        {
            InitializeComponent();

            txtName.Select();
            lblMessage.Text = "";

            SetIndicators();
        }

        private void lstPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            Keys code = e.KeyCode;

            if (code.ToString().ToUpper() == "DELETE")
                btnRemove.PerformClick();
            else if (code.ToString().Length == 1)
                btnAdd.PerformClick();
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIndicators();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnAdd;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnPlay;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageDialog d;
            DialogResult dr;
            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                lstPlayers.Items.Contains(txtName.Text.Trim()))
            {
                dr = MessageBox.Show("Please enter a unique player name into the roster.",
                                     "",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            else
            {
                lstPlayers.Items.Add(txtName.Text.Trim());

                lstPlayers.SelectedItems.Clear();
                lstPlayers.SelectedItem = lstPlayers.Items[lstPlayers.Items.Count - 1];
            }

            txtName.Focus();
            txtName.Clear();

            /*foreach (ListViewItem i in lstPlayers.Items)
                i.Selected = (i == lstPlayers.Items[lstPlayers.Items.Count - 1]);*/
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPlayers.Items.Count > 0)
            {
                int index = lstPlayers.Items.IndexOf(lstPlayers.SelectedItems[0]);

                foreach (string s in lstPlayers.SelectedItems.OfType<string>().ToList())
                    lstPlayers.Items.Remove(s);

                if (lstPlayers.Items.Count > 0)
                {
                    lstPlayers.SelectedItem =
                        lstPlayers.Items[(index > lstPlayers.Items.Count - 1) ? index - 1
                                                                              : index];
                }
            }

            txtName.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Cursor c = Cursor;

            string[] players = new string[lstPlayers.Items.Count];
            for (int i = 0; i < lstPlayers.Items.Count; i++)
                players[i] = lstPlayers.Items[i].ToString();

            lblMessage.Text = "Initializing, please wait ...";
            Cursor = Cursors.WaitCursor;
            Enabled = false;

            //

            MainForm f = new MainForm(players);
            Hide();
            f.ShowDialog();
            // Check if form is disposed so that the user can close the app
            // without crashing the program (see Program.cs Exit() method)
            if (!IsDisposed)
            {
                Show();
                
                lstPlayers.Items.Clear();
                Cursor = c;
                Enabled = true;
                txtName.Focus();

                SetIndicators();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //

        private void SetIndicators()
        {
            int playerCount = lstPlayers.Items.Count,
                selectCount = lstPlayers.SelectedItems.Count;

            lblMessage.Text = playerCount + " player" + (playerCount == 1 ? "" : "s")
                            + (selectCount > 0 ? ", " + selectCount + " selected" : "");

            btnAdd.Enabled = (playerCount < 10);
            btnRemove.Enabled = (playerCount > 0 && selectCount > 0);

            btnPlay.Enabled = (lstPlayers.Items.Count > 0);
        }
    }
}
