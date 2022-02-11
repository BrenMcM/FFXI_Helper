
namespace FFXi.Entourage_2
{
    partial class MapViewer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblSelectPlayer = new System.Windows.Forms.ToolStripLabel();
            this.cbxSelectPlayer = new System.Windows.Forms.ToolStripComboBox();
            this.lblGridSize = new System.Windows.Forms.ToolStripLabel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectPlayer,
            this.cbxSelectPlayer,
            this.lblGridSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblSelectPlayer
            // 
            this.lblSelectPlayer.Name = "lblSelectPlayer";
            this.lblSelectPlayer.Size = new System.Drawing.Size(73, 22);
            this.lblSelectPlayer.Text = "Select Player";
            // 
            // cbxSelectPlayer
            // 
            this.cbxSelectPlayer.Name = "cbxSelectPlayer";
            this.cbxSelectPlayer.Size = new System.Drawing.Size(121, 25);
            // 
            // lblGridSize
            // 
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(52, 22);
            this.lblGridSize.Text = "Grid Size";
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 25);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(629, 397);
            this.pnlCanvas.TabIndex = 2;
            // 
            // MapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MapViewer";
            this.Text = "MapViewer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ToolStripLabel lblSelectPlayer;
        private System.Windows.Forms.ToolStripComboBox cbxSelectPlayer;
        private System.Windows.Forms.ToolStripLabel lblGridSize;
    }
}