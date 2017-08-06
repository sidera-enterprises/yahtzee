using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class PlayerRoster : UserControl
    {
        #region Initialization
        public PlayerRoster()
        {
            InitializeComponent();

            MaxLength = 10;
        }
        #endregion

        #region Public properties
        public string[] Names
        {
            get
            {
                var list = lstPlayers.Items;
                string[] slist = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                    slist[i] = list[i].ToString();

                return slist;
            }
        }

        public int Length
        {
            get { return Names.Length; }
        }

        public int MaxLength
        {
            get; set;
        }
        #endregion

        #region Private event handlers
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

        private void SetIndicators()
        {
            int playerCount = lstPlayers.Items.Count,
                selectCount = lstPlayers.SelectedItems.Count;

            btnAdd.Enabled = (playerCount < 10);
            btnRemove.Enabled = (playerCount > 0 && selectCount > 0);
        }
        #endregion
    }
}
