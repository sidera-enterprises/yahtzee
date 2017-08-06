namespace Yahtzee
{
    partial class StartupDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupDialog));
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.pnlAddRemove = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpPlayers.SuspendLayout();
            this.pnlAddRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.lstPlayers);
            this.grpPlayers.Controls.Add(this.pnlAddRemove);
            this.grpPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlayers.Location = new System.Drawing.Point(13, 44);
            this.grpPlayers.Margin = new System.Windows.Forms.Padding(13);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Padding = new System.Windows.Forms.Padding(10);
            this.grpPlayers.Size = new System.Drawing.Size(393, 191);
            this.grpPlayers.TabIndex = 1;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Who\'s playing this round?";
            // 
            // lstPlayers
            // 
            this.lstPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(10, 23);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPlayers.Size = new System.Drawing.Size(373, 136);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // pnlAddRemove
            // 
            this.pnlAddRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddRemove.Controls.Add(this.txtName);
            this.pnlAddRemove.Controls.Add(this.lblName);
            this.pnlAddRemove.Controls.Add(this.btnAdd);
            this.pnlAddRemove.Controls.Add(this.btnRemove);
            this.pnlAddRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddRemove.Location = new System.Drawing.Point(10, 159);
            this.pnlAddRemove.Name = "pnlAddRemove";
            this.pnlAddRemove.Size = new System.Drawing.Size(373, 22);
            this.pnlAddRemove.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(64, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
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
            this.btnAdd.Location = new System.Drawing.Point(333, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnAdd.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.toolTip.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Location = new System.Drawing.Point(353, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnRemove.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 20);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "−";
            this.toolTip.SetToolTip(this.btnRemove, "Remove");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlay.Location = new System.Drawing.Point(250, 241);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "&Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(331, 241);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(13);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblY
            // 
            this.lblY.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblY.Font = new System.Drawing.Font("Arial Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblY.Location = new System.Drawing.Point(13, 13);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(393, 31);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "YAHTZEE!";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 246);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "_";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // StartupDialog
            // 
            this.AcceptButton = this.btnPlay;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(419, 275);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.lblY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartupDialog";
            this.Padding = new System.Windows.Forms.Padding(13, 13, 13, 40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee!";
            this.grpPlayers.ResumeLayout(false);
            this.pnlAddRemove.ResumeLayout(false);
            this.pnlAddRemove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.Panel pnlAddRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblMessage;
    }
}