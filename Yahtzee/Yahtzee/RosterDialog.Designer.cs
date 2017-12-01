namespace Yahtzee
{
    partial class RosterDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RosterDialog));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.PictureBox();
            this.lblTopDiv = new System.Windows.Forms.Label();
            this.mnuStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlRosterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.lstRoster = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblDiv = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIcon)).BeginInit();
            this.mnuStatusBar.SuspendLayout();
            this.pnlRosterLayout.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.mnuContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlIcon);
            this.pnlHeader.Controls.Add(this.lblTopDiv);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(434, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome! Who\'s playing this round?";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(67, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 44);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Yahtzee!";
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackgroundImage = global::Yahtzee.Properties.Resources.Roll;
            this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlIcon.Location = new System.Drawing.Point(13, 13);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(48, 48);
            this.pnlIcon.TabIndex = 1;
            this.pnlIcon.TabStop = false;
            // 
            // lblTopDiv
            // 
            this.lblTopDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTopDiv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTopDiv.Location = new System.Drawing.Point(0, 98);
            this.lblTopDiv.Name = "lblTopDiv";
            this.lblTopDiv.Size = new System.Drawing.Size(434, 2);
            this.lblTopDiv.TabIndex = 0;
            // 
            // mnuStatusBar
            // 
            this.mnuStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppVersion});
            this.mnuStatusBar.Location = new System.Drawing.Point(0, 288);
            this.mnuStatusBar.Name = "mnuStatusBar";
            this.mnuStatusBar.Size = new System.Drawing.Size(434, 22);
            this.mnuStatusBar.SizingGrip = false;
            this.mnuStatusBar.TabIndex = 1;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(67, 17);
            this.lblAppVersion.Text = "AppVersion";
            // 
            // pnlRosterLayout
            // 
            this.pnlRosterLayout.ColumnCount = 2;
            this.pnlRosterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRosterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRosterLayout.Controls.Add(this.lblInstructions, 0, 0);
            this.pnlRosterLayout.Controls.Add(this.lblPlayerCount, 0, 2);
            this.pnlRosterLayout.Controls.Add(this.lstRoster, 0, 1);
            this.pnlRosterLayout.Controls.Add(this.btnAdd, 1, 1);
            this.pnlRosterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRosterLayout.Location = new System.Drawing.Point(0, 100);
            this.pnlRosterLayout.Name = "pnlRosterLayout";
            this.pnlRosterLayout.RowCount = 3;
            this.pnlRosterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlRosterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRosterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlRosterLayout.Size = new System.Drawing.Size(434, 141);
            this.pnlRosterLayout.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.pnlRosterLayout.SetColumnSpan(this.lblInstructions, 2);
            this.lblInstructions.Location = new System.Drawing.Point(6, 6);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(6);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(422, 39);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Location = new System.Drawing.Point(3, 125);
            this.lblPlayerCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(44, 13);
            this.lblPlayerCount.TabIndex = 2;
            this.lblPlayerCount.Text = "1 player";
            this.lblPlayerCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstRoster
            // 
            this.lstRoster.BackColor = System.Drawing.SystemColors.Control;
            this.lstRoster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRoster.Location = new System.Drawing.Point(3, 54);
            this.lstRoster.Name = "lstRoster";
            this.lstRoster.Size = new System.Drawing.Size(347, 65);
            this.lstRoster.TabIndex = 0;
            this.lstRoster.UseCompatibleStateImageBehavior = false;
            this.lstRoster.SelectedIndexChanged += new System.EventHandler(this.lstRoster_SelectedIndexChanged);
            this.lstRoster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstRoster_KeyDown);
            this.lstRoster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstRoster_MouseClick);
            this.lstRoster.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRoster_MouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(356, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnQuit);
            this.pnlOptions.Controls.Add(this.btnPlay);
            this.pnlOptions.Controls.Add(this.btnHelp);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptions.Location = new System.Drawing.Point(0, 241);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(434, 47);
            this.pnlOptions.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(356, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 40);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(275, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "&Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHelp.Location = new System.Drawing.Point(3, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 40);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblDiv
            // 
            this.lblDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDiv.Location = new System.Drawing.Point(0, 239);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(434, 2);
            this.lblDiv.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mnuContextMenu
            // 
            this.mnuContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRename,
            this.mnuDelete});
            this.mnuContextMenu.Name = "mnuContextMenu";
            this.mnuContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // mnuRename
            // 
            this.mnuRename.Name = "mnuRename";
            this.mnuRename.Size = new System.Drawing.Size(117, 22);
            this.mnuRename.Text = "&Rename";
            this.mnuRename.Click += new System.EventHandler(this.mnuRename_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(117, 22);
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // RosterDialog
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(434, 310);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.pnlRosterLayout);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.mnuStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RosterDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee! Game Setup";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIcon)).EndInit();
            this.mnuStatusBar.ResumeLayout(false);
            this.mnuStatusBar.PerformLayout();
            this.pnlRosterLayout.ResumeLayout(false);
            this.pnlRosterLayout.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.mnuContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pnlIcon;
        private System.Windows.Forms.Label lblTopDiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip mnuStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblAppVersion;
        private System.Windows.Forms.TableLayoutPanel pnlRosterLayout;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListView lstRoster;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRename;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}