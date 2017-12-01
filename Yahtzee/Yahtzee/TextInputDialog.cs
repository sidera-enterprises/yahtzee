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
    public partial class TextInputDialog : Form
    {
        public TextInputDialog(string title) : this(title, "", 0) { }
        public TextInputDialog(string title, int maxLength) : this(title, "", maxLength) { }
        public TextInputDialog(string title, string text) : this(title, text, 0) { }
        public TextInputDialog(string title, string text, int maxLength)
        {
            InitializeComponent();

            lblMessage.Text = title;
            txtInput.Text = text;
            txtInput.MaxLength = maxLength;

            btnOK.Enabled = !String.IsNullOrWhiteSpace(Text);
        }

        public string Title { get { return lblMessage.Text; } }
        public new string Text { get { return txtInput.Text; } }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = !String.IsNullOrWhiteSpace(Text);
        }
    }
}
