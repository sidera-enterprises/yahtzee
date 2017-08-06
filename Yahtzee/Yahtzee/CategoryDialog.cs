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
    public partial class CategoryDialog : Form
    {
        public CategoryDialog(List<string> categories)
        {
            InitializeComponent();

            foreach (string s in categories)
            {
                cbxCategories.Items.Add(s.ToUpper());
            }

            btnOK.Enabled = !String.IsNullOrWhiteSpace(Value);
        }

        public string Value { get { return cbxCategories.Text; } }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = !String.IsNullOrWhiteSpace(Value);
        }
    }
}
