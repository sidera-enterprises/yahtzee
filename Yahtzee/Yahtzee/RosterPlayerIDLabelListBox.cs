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
    public partial class RosterPlayerIDLabelListBox : UserControl
    {
        #region Initialization
        public RosterPlayerIDLabelListBox()
        {
            InitializeComponent();

            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Fill;
        }
        #endregion

        #region Public properties
        public int PlayerCount
        {
            get
            {
                int count = 0;
                foreach (Control c in pnlList.Controls)
                    if (c is RosterPlayerIDLabel) count++;
                return count;
            }
        }

        public int MaxPlayerCount
        {
            get { return 4; }
        }

        public bool CanAddPlayer
        {
            get { return PlayerCount < MaxPlayerCount; }
        }

        public List<RosterPlayerIDLabel> PlayerIDLabels
        {
            get
            {
                List<RosterPlayerIDLabel> l = new List<RosterPlayerIDLabel>();

                foreach (Control c in pnlList.Controls)
                    if (c is RosterPlayerIDLabel) l.Add(c as RosterPlayerIDLabel);

                return l;
            }
        }

        public List<string> PlayerNames
        {
            get
            {
                List<string> l = new List<string>();

                foreach (RosterPlayerIDLabel r in PlayerIDLabels)
                    l.Add(r.Text);

                return l;
            }
        }
        #endregion

        #region Public methods
        public void AddPlayer()
        {
            if (CanAddPlayer)
            {
                RosterPlayerIDLabel r = new RosterPlayerIDLabel("Player");

                pnlList.Controls.Add(r);
                r.Margin = new Padding(0);
                r.Width = r.Parent.Width;

                OnPlayerCountChanged(EventArgs.Empty);
            }
        }

        public void RemovePlayer(RosterPlayerIDLabel player)
        {
            foreach (Control c in pnlList.Controls)
            {
                if (c is RosterPlayerIDLabel)
                {
                    RosterPlayerIDLabel r = c as RosterPlayerIDLabel;

                    if (c.Text == player.Text) ;
                }
            }
        }
        #endregion

        #region Public event handlers
        public delegate void PlayerCountChangedEventHandler(object sender, EventArgs e);
        public event PlayerCountChangedEventHandler PlayerCountChanged;
        protected virtual void OnPlayerCountChanged(EventArgs e)
        {
            PlayerCountChangedEventHandler handler = PlayerCountChanged;
            if (handler != null) handler(this, e);
        }
        #endregion

        #region Private events
        private void RosterPlayerIDLabelListBox_Resize(object sender, EventArgs e)
        {
            int w = Width;
            pnlList.MinimumSize = new Size(w, 0);
            pnlList.MaximumSize = new Size(w, 1000);
        }

        private void pnlList_ControlAdded(object sender, ControlEventArgs e)
        {
            PlayerIDLabels[PlayerIDLabels.Count - 1].Focus();

            OnPlayerCountChanged(EventArgs.Empty);
        }

        private void pnlList_ControlRemoved(object sender, ControlEventArgs e)
        {
            OnPlayerCountChanged(EventArgs.Empty);
        }

        private void pnlList_Resize(object sender, EventArgs e)
        {
            foreach (Control c in pnlList.Controls)
                c.Width = pnlList.Width - 2;
        }
        #endregion

        private void background_MouseClick(object sender, MouseEventArgs e)
        {
            Focus();
        }
    }
}
