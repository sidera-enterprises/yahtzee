namespace Yahtzee
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDocBorder = new System.Windows.Forms.Panel();
            this.webHelpDoc = new System.Windows.Forms.WebBrowser();
            this.mnuMenuBar.SuspendLayout();
            this.pnlDocBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.helpToolStripMenuItem});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mnuMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMenuBar.Size = new System.Drawing.Size(480, 24);
            this.mnuMenuBar.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Close});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 22);
            this.mnuFile.Text = "&File";
            // 
            // mnuFile_Close
            // 
            this.mnuFile_Close.Name = "mnuFile_Close";
            this.mnuFile_Close.Size = new System.Drawing.Size(103, 22);
            this.mnuFile_Close.Text = "&Close";
            this.mnuFile_Close.Click += new System.EventHandler(this.mnuFile_Close_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(153, 22);
            this.mnuHelp_About.Text = "&About Yahtzee!";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // pnlDocBorder
            // 
            this.pnlDocBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDocBorder.Controls.Add(this.webHelpDoc);
            this.pnlDocBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocBorder.Location = new System.Drawing.Point(0, 24);
            this.pnlDocBorder.Name = "pnlDocBorder";
            this.pnlDocBorder.Size = new System.Drawing.Size(480, 342);
            this.pnlDocBorder.TabIndex = 1;
            // 
            // webHelpDoc
            // 
            this.webHelpDoc.AllowWebBrowserDrop = false;
            this.webHelpDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webHelpDoc.IsWebBrowserContextMenuEnabled = false;
            this.webHelpDoc.Location = new System.Drawing.Point(0, 0);
            this.webHelpDoc.MinimumSize = new System.Drawing.Size(20, 20);
            this.webHelpDoc.Name = "webHelpDoc";
            this.webHelpDoc.ScriptErrorsSuppressed = true;
            this.webHelpDoc.Size = new System.Drawing.Size(476, 338);
            this.webHelpDoc.TabIndex = 0;
            this.webHelpDoc.WebBrowserShortcutsEnabled = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 366);
            this.Controls.Add(this.pnlDocBorder);
            this.Controls.Add(this.mnuMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuBar;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yahtzee! Documentation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.pnlDocBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Close;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.Panel pnlDocBorder;
        private System.Windows.Forms.WebBrowser webHelpDoc;
    }
}