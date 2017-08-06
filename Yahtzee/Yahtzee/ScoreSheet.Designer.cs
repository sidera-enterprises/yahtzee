namespace Yahtzee
{
    partial class ScoreSheet
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
            this.pnlScoreTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlScoreTable
            // 
            this.pnlScoreTable.AutoSize = true;
            this.pnlScoreTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlScoreTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlScoreTable.ColumnCount = 2;
            this.pnlScoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlScoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlScoreTable.Location = new System.Drawing.Point(3, 3);
            this.pnlScoreTable.Name = "pnlScoreTable";
            this.pnlScoreTable.RowCount = 1;
            this.pnlScoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlScoreTable.Size = new System.Drawing.Size(6, 4);
            this.pnlScoreTable.TabIndex = 0;
            // 
            // ScoreSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlScoreTable);
            this.Name = "ScoreSheet";
            this.Size = new System.Drawing.Size(12, 10);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pnlScoreTable;
    }
}
