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
    public partial class RosterPlayerIDLabel : UserControl
    {
        #region Initialization
        private Color _backColor, _highlightBackColor, _mouseoverBackColor;
        private Color _foreColor, _highlightForeColor, _mouseoverForeColor;
        public RosterPlayerIDLabel(string name)
        {
            InitializeComponent();

            Cursor = Cursors.Hand;

            BackColor = Color.Transparent;
            HighlightBackColor = SystemColors.Highlight;
            MouseOverBackColor = SystemColors.ControlDark;

            ForeColor = SystemColors.ControlText;
            HighlightForeColor = SystemColors.HighlightText;
            MouseOverForeColor = SystemColors.ControlText;

            Text = name;
            Editable = true;
            
            // Add context menus to all controls
            ContextMenuStrip = mnuContext;
            foreach (Control c1 in Controls)
            {
                c1.ContextMenuStrip = mnuContext;
                foreach (Control c2 in Controls)
                    c2.ContextMenuStrip = mnuContext;
            }
        }
        #endregion

        #region Public properties
        public new Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                if (!Focused) base.BackColor = value;
            }
        }

        public Color HighlightBackColor
        {
            get { return _highlightBackColor; }
            set
            {
                _highlightBackColor = value;
                if (Focused) base.BackColor = value;
            }
        }

        public Color MouseOverBackColor
        {
            get { return _mouseoverBackColor; }
            set
            {
                _mouseoverBackColor = value;
                if (Focused) base.BackColor = value;
            }
        }

        public new Color ForeColor
        {
            get { return _foreColor; }
            set
            {
                _foreColor = value;
                if (!Focused) base.ForeColor = value;
            }
        }

        public Color HighlightForeColor
        {
            get { return _highlightForeColor; }
            set
            {
                _highlightForeColor = value;
                if (Focused) base.ForeColor = value;
            }
        }

        public Color MouseOverForeColor
        {
            get { return _mouseoverForeColor; }
            set
            {
                _mouseoverForeColor = value;
                if (Focused) base.ForeColor = value;
            }
        }

        public bool Editable
        {
            get { return txtPlayerName.Visible; }
            set
            {
                lblPlayerName.Visible = !value;
                txtPlayerName.Visible = value;

                mnuEdit.Checked = value;

                if (txtPlayerName.Visible)
                {
                    txtPlayerName.Focus();
                    txtPlayerName.SelectAll();
                }
            }
        }

        public override string Text
        {
            get { return lblPlayerName.Text; }
            set { lblPlayerName.Text = txtPlayerName.Text = value; }
        }
        #endregion

        #region Private events
        private void RosterPlayerIDLabel_Enter(object sender, EventArgs e)
        {
            base.BackColor = HighlightBackColor;
            base.ForeColor = HighlightForeColor;
        }

        private void RosterPlayerIDLabel_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Text))
                btnDelete.PerformClick();
            else
            {
                base.BackColor = BackColor;
                base.ForeColor = ForeColor;

                Editable = false;
            }
        }

        private void RosterPlayerIDLabel_MouseEnter(object sender, EventArgs e)
        {
            /*base.BackColor = Focused ? HighlightBackColor : MouseOverBackColor;
            base.ForeColor = Focused ? HighlightForeColor : MouseOverForeColor;*/
        }

        private void RosterPlayerIDLabel_MouseLeave(object sender, EventArgs e)
        {
            /*base.BackColor = Focused ? HighlightBackColor : BackColor;
            base.ForeColor = Focused ? HighlightForeColor : ForeColor;*/
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            Editable = !Editable;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Parent.Controls.Remove(this);
                Dispose();
            }
        }

        private void background_MouseClick(object sender, MouseEventArgs e)
        {
            Editable = false;
            Focus();
        }

        private void lblPlayerName_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Editable = true;

            Focus();
        }

        private void txtPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                Editable = false;

                if (e.KeyCode == Keys.Escape)
                {
                    if (String.IsNullOrWhiteSpace(Text))
                        btnDelete.PerformClick();
                }
                else if (e.KeyCode == Keys.Enter) Text = txtPlayerName.Text;
                else txtPlayerName.Text = Text;
            }
        }
        #endregion
    }
}
