namespace Yahtzee
{
    partial class Die
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Black;
            this.pnlBorder.Controls.Add(this.pnlFace);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBorder.Size = new System.Drawing.Size(66, 66);
            this.pnlBorder.TabIndex = 0;
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.White;
            this.pnlFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFace.Location = new System.Drawing.Point(1, 1);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Padding = new System.Windows.Forms.Padding(1);
            this.pnlFace.Size = new System.Drawing.Size(64, 64);
            this.pnlFace.TabIndex = 0;
            this.pnlFace.BackColorChanged += new System.EventHandler(this.pnlFace_BackColorChanged);
            this.pnlFace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlFace_MouseClick);
            // 
            // Die
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBorder);
            this.Name = "Die";
            this.Size = new System.Drawing.Size(66, 66);
            this.pnlBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlFace;
    }
}
