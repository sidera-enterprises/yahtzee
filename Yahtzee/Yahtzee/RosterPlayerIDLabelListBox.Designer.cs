namespace Yahtzee
{
    partial class RosterPlayerIDLabelListBox
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
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.AutoSize = true;
            this.pnlList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlList.MinimumSize = new System.Drawing.Size(200, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(200, 0);
            this.pnlList.TabIndex = 0;
            this.pnlList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlList_ControlAdded);
            this.pnlList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlList_ControlRemoved);
            this.pnlList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.background_MouseClick);
            this.pnlList.Resize += new System.EventHandler(this.pnlList_Resize);
            // 
            // RosterPlayerIDLabelListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RosterPlayerIDLabelListBox";
            this.Size = new System.Drawing.Size(204, 204);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.background_MouseClick);
            this.Resize += new System.EventHandler(this.RosterPlayerIDLabelListBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlList;
    }
}
