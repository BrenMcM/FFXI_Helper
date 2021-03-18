
namespace FFXI.MainUI.UserControls
{
    partial class ItemView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSuperLevel = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtItemDescription1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSuperLevel);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Controls.Add(this.pcbIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblSuperLevel
            // 
            this.lblSuperLevel.AutoSize = true;
            this.lblSuperLevel.Location = new System.Drawing.Point(168, 71);
            this.lblSuperLevel.Name = "lblSuperLevel";
            this.lblSuperLevel.Size = new System.Drawing.Size(41, 17);
            this.lblSuperLevel.TabIndex = 3;
            this.lblSuperLevel.Text = "Su: 0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(101, 71);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(39, 17);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Lv: 0";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(99, 29);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(150, 29);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "lblItemName";
            // 
            // pcbIcon
            // 
            this.pcbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbIcon.Location = new System.Drawing.Point(4, 4);
            this.pcbIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(87, 84);
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 43);
            this.panel2.TabIndex = 1;
            // 
            // txtItemDescription1
            // 
            this.txtItemDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemDescription1.Location = new System.Drawing.Point(7, 141);
            this.txtItemDescription1.Multiline = true;
            this.txtItemDescription1.Name = "txtItemDescription1";
            this.txtItemDescription1.ReadOnly = true;
            this.txtItemDescription1.Size = new System.Drawing.Size(323, 315);
            this.txtItemDescription1.TabIndex = 2;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtItemDescription1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemView";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(337, 462);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblSuperLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtItemDescription1;
    }
}
