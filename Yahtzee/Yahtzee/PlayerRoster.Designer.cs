namespace Yahtzee
{
    partial class PlayerRoster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddRemove = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.pnlAddRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddRemove
            // 
            this.pnlAddRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddRemove.Controls.Add(this.txtName);
            this.pnlAddRemove.Controls.Add(this.lblName);
            this.pnlAddRemove.Controls.Add(this.btnAdd);
            this.pnlAddRemove.Controls.Add(this.btnRemove);
            this.pnlAddRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddRemove.Location = new System.Drawing.Point(0, 178);
            this.pnlAddRemove.Name = "pnlAddRemove";
            this.pnlAddRemove.Size = new System.Drawing.Size(300, 22);
            this.pnlAddRemove.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(64, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Click += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter name:";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(260, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnAdd.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Location = new System.Drawing.Point(280, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnRemove.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 20);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "−";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(0, 0);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPlayers.Size = new System.Drawing.Size(300, 178);
            this.lstPlayers.TabIndex = 2;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // PlayerRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.pnlAddRemove);
            this.Name = "PlayerRoster";
            this.Size = new System.Drawing.Size(300, 200);
            this.pnlAddRemove.ResumeLayout(false);
            this.pnlAddRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstPlayers;
    }
}
