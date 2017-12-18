namespace Yahtzee
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGame_HighScores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGame_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGame_sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGame_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_TouchMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDiceCheckedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlScoreBoard = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDiceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnSelectCategory = new System.Windows.Forms.Button();
            this.pnlOtherControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDiv = new System.Windows.Forms.Label();
            this.die1 = new Yahtzee.Die();
            this.die2 = new Yahtzee.Die();
            this.die3 = new Yahtzee.Die();
            this.die4 = new Yahtzee.Die();
            this.die5 = new Yahtzee.Die();
            this.mnuMenuBar.SuspendLayout();
            this.mnuStatusBar.SuspendLayout();
            this.pnlDiceLayout.SuspendLayout();
            this.pnlOtherControls.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.BackColor = System.Drawing.SystemColors.Window;
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.mnuView,
            this.mnuHelp});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mnuMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMenuBar.Size = new System.Drawing.Size(684, 24);
            this.mnuMenuBar.TabIndex = 0;
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame_New,
            this.mnuGame_Load,
            this.mnuGame_Save,
            this.mnuGame_sep1,
            this.mnuGame_HighScores,
            this.mnuGame_sep2,
            this.mnuGame_Options,
            this.mnuGame_sep3,
            this.mnuGame_Exit});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(50, 22);
            this.mnuGame.Text = "&Game";
            // 
            // mnuGame_New
            // 
            this.mnuGame_New.Name = "mnuGame_New";
            this.mnuGame_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuGame_New.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_New.Text = "&New game";
            this.mnuGame_New.Click += new System.EventHandler(this.mnuGame_New_Click);
            // 
            // mnuGame_Load
            // 
            this.mnuGame_Load.Enabled = false;
            this.mnuGame_Load.Name = "mnuGame_Load";
            this.mnuGame_Load.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuGame_Load.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_Load.Text = "&Load restore point";
            this.mnuGame_Load.Visible = false;
            this.mnuGame_Load.Click += new System.EventHandler(this.mnuGame_Load_Click);
            // 
            // mnuGame_Save
            // 
            this.mnuGame_Save.Enabled = false;
            this.mnuGame_Save.Name = "mnuGame_Save";
            this.mnuGame_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuGame_Save.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_Save.Text = "&Save restore point";
            this.mnuGame_Save.Visible = false;
            this.mnuGame_Save.Click += new System.EventHandler(this.mnuGame_Save_Click);
            // 
            // mnuGame_sep1
            // 
            this.mnuGame_sep1.Name = "mnuGame_sep1";
            this.mnuGame_sep1.Size = new System.Drawing.Size(210, 6);
            this.mnuGame_sep1.Visible = false;
            // 
            // mnuGame_HighScores
            // 
            this.mnuGame_HighScores.Enabled = false;
            this.mnuGame_HighScores.Name = "mnuGame_HighScores";
            this.mnuGame_HighScores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuGame_HighScores.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_HighScores.Text = "&High scores";
            this.mnuGame_HighScores.Visible = false;
            this.mnuGame_HighScores.Click += new System.EventHandler(this.mnuGame_HighScores_Click);
            // 
            // mnuGame_sep2
            // 
            this.mnuGame_sep2.Name = "mnuGame_sep2";
            this.mnuGame_sep2.Size = new System.Drawing.Size(210, 6);
            this.mnuGame_sep2.Visible = false;
            // 
            // mnuGame_Options
            // 
            this.mnuGame_Options.Name = "mnuGame_Options";
            this.mnuGame_Options.ShortcutKeyDisplayString = "Ctrl+,";
            this.mnuGame_Options.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.mnuGame_Options.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_Options.Text = "&Options";
            this.mnuGame_Options.Visible = false;
            this.mnuGame_Options.Click += new System.EventHandler(this.mnuGame_Options_Click);
            // 
            // mnuGame_sep3
            // 
            this.mnuGame_sep3.Name = "mnuGame_sep3";
            this.mnuGame_sep3.Size = new System.Drawing.Size(210, 6);
            // 
            // mnuGame_Exit
            // 
            this.mnuGame_Exit.Name = "mnuGame_Exit";
            this.mnuGame_Exit.ShortcutKeyDisplayString = "";
            this.mnuGame_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuGame_Exit.Size = new System.Drawing.Size(213, 22);
            this.mnuGame_Exit.Text = "E&xit";
            this.mnuGame_Exit.Click += new System.EventHandler(this.mnuGame_Exit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_TouchMode});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 22);
            this.mnuView.Text = "&View";
            this.mnuView.Visible = false;
            // 
            // mnuView_TouchMode
            // 
            this.mnuView_TouchMode.CheckOnClick = true;
            this.mnuView_TouchMode.Name = "mnuView_TouchMode";
            this.mnuView_TouchMode.Size = new System.Drawing.Size(141, 22);
            this.mnuView_TouchMode.Text = "&Touch mode";
            this.mnuView_TouchMode.Visible = false;
            this.mnuView_TouchMode.CheckedChanged += new System.EventHandler(this.mnuView_TouchMode_CheckedChanged);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_Help,
            this.mnuHelp_sep1,
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 22);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp_Help
            // 
            this.mnuHelp_Help.Name = "mnuHelp_Help";
            this.mnuHelp_Help.ShortcutKeyDisplayString = "";
            this.mnuHelp_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp_Help.Size = new System.Drawing.Size(162, 22);
            this.mnuHelp_Help.Text = "&Help content";
            this.mnuHelp_Help.Click += new System.EventHandler(this.mnuHelp_Help_Click);
            // 
            // mnuHelp_sep1
            // 
            this.mnuHelp_sep1.Name = "mnuHelp_sep1";
            this.mnuHelp_sep1.Size = new System.Drawing.Size(159, 6);
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(162, 22);
            this.mnuHelp_About.Text = "&About Yahtzee!";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // mnuStatusBar
            // 
            this.mnuStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.lblDiceCheckedCount});
            this.mnuStatusBar.Location = new System.Drawing.Point(0, 539);
            this.mnuStatusBar.Name = "mnuStatusBar";
            this.mnuStatusBar.Size = new System.Drawing.Size(684, 22);
            this.mnuStatusBar.TabIndex = 3;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(560, 17);
            this.lblStatusMessage.Spring = true;
            this.lblStatusMessage.Text = "StatusMessage";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiceCheckedCount
            // 
            this.lblDiceCheckedCount.Name = "lblDiceCheckedCount";
            this.lblDiceCheckedCount.Size = new System.Drawing.Size(109, 17);
            this.lblDiceCheckedCount.Text = "DiceCheckedCount";
            // 
            // pnlScoreBoard
            // 
            this.pnlScoreBoard.AutoSize = true;
            this.pnlScoreBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlScoreBoard.Location = new System.Drawing.Point(75, 24);
            this.pnlScoreBoard.Name = "pnlScoreBoard";
            this.pnlScoreBoard.Size = new System.Drawing.Size(0, 0);
            this.pnlScoreBoard.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.Green;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 94);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(684, 445);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlDiceLayout
            // 
            this.pnlDiceLayout.AutoSize = true;
            this.pnlDiceLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDiceLayout.Controls.Add(this.btnRollDice);
            this.pnlDiceLayout.Controls.Add(this.btnSelectCategory);
            this.pnlDiceLayout.Controls.Add(this.die1);
            this.pnlDiceLayout.Controls.Add(this.die2);
            this.pnlDiceLayout.Controls.Add(this.die3);
            this.pnlDiceLayout.Controls.Add(this.die4);
            this.pnlDiceLayout.Controls.Add(this.die5);
            this.pnlDiceLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlDiceLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDiceLayout.Name = "pnlDiceLayout";
            this.pnlDiceLayout.Size = new System.Drawing.Size(476, 68);
            this.pnlDiceLayout.TabIndex = 0;
            // 
            // btnRollDice
            // 
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRollDice.Image = global::Yahtzee.Properties.Resources.Roll;
            this.btnRollDice.Location = new System.Drawing.Point(1, 1);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(1);
            this.btnRollDice.MaximumSize = new System.Drawing.Size(66, 66);
            this.btnRollDice.MinimumSize = new System.Drawing.Size(66, 33);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(66, 66);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll";
            this.btnRollDice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnSelectCategory
            // 
            this.btnSelectCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCategory.Image = global::Yahtzee.Properties.Resources.Check;
            this.btnSelectCategory.Location = new System.Drawing.Point(69, 1);
            this.btnSelectCategory.Margin = new System.Windows.Forms.Padding(1);
            this.btnSelectCategory.MaximumSize = new System.Drawing.Size(66, 66);
            this.btnSelectCategory.MinimumSize = new System.Drawing.Size(66, 33);
            this.btnSelectCategory.Name = "btnSelectCategory";
            this.btnSelectCategory.Size = new System.Drawing.Size(66, 66);
            this.btnSelectCategory.TabIndex = 1;
            this.btnSelectCategory.Text = "Submit";
            this.btnSelectCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelectCategory.UseVisualStyleBackColor = true;
            this.btnSelectCategory.Visible = false;
            this.btnSelectCategory.Click += new System.EventHandler(this.btnSelectCategory_Click);
            // 
            // pnlOtherControls
            // 
            this.pnlOtherControls.AutoSize = true;
            this.pnlOtherControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOtherControls.Controls.Add(this.btnHelp);
            this.pnlOtherControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOtherControls.Location = new System.Drawing.Point(616, 0);
            this.pnlOtherControls.Name = "pnlOtherControls";
            this.pnlOtherControls.Size = new System.Drawing.Size(68, 68);
            this.pnlOtherControls.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(1, 1);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(1);
            this.btnHelp.MaximumSize = new System.Drawing.Size(66, 66);
            this.btnHelp.MinimumSize = new System.Drawing.Size(66, 33);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 66);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help (F1)";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.mnuHelp_Help_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoSize = true;
            this.pnlDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDashboard.Controls.Add(this.pnlOtherControls);
            this.pnlDashboard.Controls.Add(this.pnlDiceLayout);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 26);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(684, 68);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDiv
            // 
            this.lblDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiv.Location = new System.Drawing.Point(0, 24);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(684, 2);
            this.lblDiv.TabIndex = 0;
            this.lblDiv.Visible = false;
            // 
            // die1
            // 
            this.die1.Checked = false;
            this.die1.CheckedColor = System.Drawing.SystemColors.Highlight;
            this.die1.Location = new System.Drawing.Point(137, 1);
            this.die1.Margin = new System.Windows.Forms.Padding(1);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(66, 66);
            this.die1.TabIndex = 2;
            this.die1.Value = 0;
            this.die1.CheckedChanged += new Yahtzee.Die.CheckedChangedEventHandler(this.die_CheckedChanged);
            this.die1.ValueChanged += new Yahtzee.Die.ValueChangedEventHandler(this.die_ValueChanged);
            // 
            // die2
            // 
            this.die2.Checked = false;
            this.die2.CheckedColor = System.Drawing.SystemColors.Highlight;
            this.die2.Location = new System.Drawing.Point(205, 1);
            this.die2.Margin = new System.Windows.Forms.Padding(1);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(66, 66);
            this.die2.TabIndex = 3;
            this.die2.Value = 0;
            this.die2.CheckedChanged += new Yahtzee.Die.CheckedChangedEventHandler(this.die_CheckedChanged);
            this.die2.ValueChanged += new Yahtzee.Die.ValueChangedEventHandler(this.die_ValueChanged);
            // 
            // die3
            // 
            this.die3.Checked = false;
            this.die3.CheckedColor = System.Drawing.SystemColors.Highlight;
            this.die3.Location = new System.Drawing.Point(273, 1);
            this.die3.Margin = new System.Windows.Forms.Padding(1);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(66, 66);
            this.die3.TabIndex = 4;
            this.die3.Value = 0;
            this.die3.CheckedChanged += new Yahtzee.Die.CheckedChangedEventHandler(this.die_CheckedChanged);
            this.die3.ValueChanged += new Yahtzee.Die.ValueChangedEventHandler(this.die_ValueChanged);
            // 
            // die4
            // 
            this.die4.Checked = false;
            this.die4.CheckedColor = System.Drawing.SystemColors.Highlight;
            this.die4.Location = new System.Drawing.Point(341, 1);
            this.die4.Margin = new System.Windows.Forms.Padding(1);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(66, 66);
            this.die4.TabIndex = 5;
            this.die4.Value = 0;
            this.die4.CheckedChanged += new Yahtzee.Die.CheckedChangedEventHandler(this.die_CheckedChanged);
            this.die4.ValueChanged += new Yahtzee.Die.ValueChangedEventHandler(this.die_ValueChanged);
            // 
            // die5
            // 
            this.die5.Checked = false;
            this.die5.CheckedColor = System.Drawing.SystemColors.Highlight;
            this.die5.Location = new System.Drawing.Point(409, 1);
            this.die5.Margin = new System.Windows.Forms.Padding(1);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(66, 66);
            this.die5.TabIndex = 6;
            this.die5.Value = 0;
            this.die5.CheckedChanged += new Yahtzee.Die.CheckedChangedEventHandler(this.die_CheckedChanged);
            this.die5.ValueChanged += new Yahtzee.Die.ValueChangedEventHandler(this.die_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlScoreBoard);
            this.Controls.Add(this.mnuStatusBar);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.mnuMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuBar;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.mnuStatusBar.ResumeLayout(false);
            this.mnuStatusBar.PerformLayout();
            this.pnlDiceLayout.ResumeLayout(false);
            this.pnlOtherControls.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.StatusStrip mnuStatusBar;
        private System.Windows.Forms.Panel pnlScoreBoard;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_New;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_Load;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_Save;
        private System.Windows.Forms.ToolStripSeparator mnuGame_sep1;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_HighScores;
        private System.Windows.Forms.ToolStripSeparator mnuGame_sep2;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_Options;
        private System.Windows.Forms.ToolStripSeparator mnuGame_sep3;
        private System.Windows.Forms.ToolStripMenuItem mnuGame_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Help;
        private System.Windows.Forms.ToolStripSeparator mnuHelp_sep1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel pnlDiceLayout;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnSelectCategory;
        private Die die1;
        private Die die2;
        private Die die3;
        private Die die4;
        private Die die5;
        private System.Windows.Forms.FlowLayoutPanel pnlOtherControls;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuView_TouchMode;
        private System.Windows.Forms.ToolStripStatusLabel lblDiceCheckedCount;
    }
}

