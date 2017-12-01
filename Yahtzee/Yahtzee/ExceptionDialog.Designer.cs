namespace Yahtzee
{
    partial class ExceptionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionDialog));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAutoRestart = new System.Windows.Forms.CheckBox();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnlHeader.Controls.Add(this.lblDiv);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 71);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDiv
            // 
            this.lblDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDiv.Location = new System.Drawing.Point(0, 69);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(584, 2);
            this.lblDiv.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(66, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(442, 39);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Something went wrong and caused $APP_NAME to shut down unexpectedly.\r\n\r\nSee below" +
    " for details.";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picIcon.BackgroundImage = global::Yahtzee.Properties.Resources.Crash;
            this.picIcon.Location = new System.Drawing.Point(12, 11);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(48, 48);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAutoRestart);
            this.panel1.Controls.Add(this.btnTerminate);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 49);
            this.panel1.TabIndex = 1;
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAutoRestart.AutoSize = true;
            this.chkAutoRestart.Checked = true;
            this.chkAutoRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRestart.Location = new System.Drawing.Point(12, 16);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.Size = new System.Drawing.Size(124, 17);
            this.chkAutoRestart.TabIndex = 0;
            this.chkAutoRestart.Text = "Restart automatically";
            this.chkAutoRestart.UseVisualStyleBackColor = true;
            this.chkAutoRestart.CheckedChanged += new System.EventHandler(this.chkAutoRestart_CheckedChanged);
            // 
            // btnTerminate
            // 
            this.btnTerminate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTerminate.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnTerminate.Location = new System.Drawing.Point(497, 13);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(75, 23);
            this.btnTerminate.TabIndex = 2;
            this.btnTerminate.Text = "&Terminate";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRestart.Location = new System.Drawing.Point(416, 13);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMessage.Location = new System.Drawing.Point(0, 71);
            this.txtErrorMessage.MaxLength = 0;
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.ReadOnly = true;
            this.txtErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorMessage.Size = new System.Drawing.Size(584, 191);
            this.txtErrorMessage.TabIndex = 2;
            this.txtErrorMessage.Text = "Exception message";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ExceptionDialog
            // 
            this.AcceptButton = this.btnRestart;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTerminate;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "ExceptionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The application $APP_NAME has crashed.";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtErrorMessage;
        private System.Windows.Forms.CheckBox chkAutoRestart;
        private System.Windows.Forms.Timer timer;
    }
}