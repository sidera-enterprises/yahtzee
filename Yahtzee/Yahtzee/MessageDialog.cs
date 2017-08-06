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
    public partial class MessageDialog : Form
    {
        public MessageDialog(string body)
            : this(body, "", Buttons.OK, Icon.None) { }
        public MessageDialog(string body, string title)
            : this(body, title, Buttons.OK, Icon.None) { }
        public MessageDialog(string body, string title, Buttons buttons)
            : this(body, title, buttons, Icon.None) { }
        public MessageDialog(string body, string title, Buttons buttons, Icon icon)
        {
            InitializeComponent();

            label1.Text = body;
            Text = title;

            btnOK.Visible = (buttons == Buttons.OK || buttons == Buttons.OKCancel);
            btnYes.Visible = (buttons == Buttons.YesNo || buttons == Buttons.YesNoCancel);
            btnNo.Visible = btnYes.Visible;
            btnCancel.Visible = (buttons == Buttons.OKCancel || buttons == Buttons.YesNoCancel);
            pnlControls.Visible = (buttons != Buttons.None);

            if (btnOK.Visible) AcceptButton = btnOK;
            else if (btnYes.Visible) AcceptButton = btnYes;

            if (btnCancel.Visible) CancelButton = btnCancel;
            else if (btnNo.Visible) CancelButton = btnNo;
            else CancelButton = btnOK;

            picIcon.Visible = (icon != Icon.None);

            if (!picIcon.Visible)
            {
                label1.MaximumSize = new Size(label1.MaximumSize.Width
                                            + picIcon.Margin.Left
                                            + picIcon.Width
                                            + picIcon.Margin.Right,
                                              label1.MaximumSize.Height);
            }
        }

        public enum Buttons
        {
            OK,
            OKCancel,
            YesNo,
            YesNoCancel,
            None
        }

        public enum Icon
        {
            Information,
            Warning,
            Error,
            Question,
            None
        }
    }
}
