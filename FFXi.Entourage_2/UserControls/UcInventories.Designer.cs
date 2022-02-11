
namespace FFXI.Entourage_2.UserControls
{
    partial class UcInventories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInventories));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TcInventories = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAllMembers = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.TcInventories.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // TcInventories
            // 
            this.TcInventories.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TcInventories.Controls.Add(this.tabPage1);
            this.TcInventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcInventories.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TcInventories.ItemSize = new System.Drawing.Size(30, 120);
            this.TcInventories.Location = new System.Drawing.Point(0, 25);
            this.TcInventories.Multiline = true;
            this.TcInventories.Name = "TcInventories";
            this.TcInventories.SelectedIndex = 0;
            this.TcInventories.Size = new System.Drawing.Size(365, 377);
            this.TcInventories.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TcInventories.TabIndex = 2;
            this.TcInventories.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcInventories_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAllMembers);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(237, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAllMembers
            // 
            this.dgvAllMembers.AllowUserToDeleteRows = false;
            this.dgvAllMembers.AllowUserToOrderColumns = true;
            this.dgvAllMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllMembers.Location = new System.Drawing.Point(3, 3);
            this.dgvAllMembers.MultiSelect = false;
            this.dgvAllMembers.Name = "dgvAllMembers";
            this.dgvAllMembers.ReadOnly = true;
            this.dgvAllMembers.RowTemplate.Height = 25;
            this.dgvAllMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllMembers.Size = new System.Drawing.Size(231, 363);
            this.dgvAllMembers.TabIndex = 2;
            // 
            // UcInventories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TcInventories);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UcInventories";
            this.Size = new System.Drawing.Size(365, 402);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TcInventories.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl TcInventories;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAllMembers;
    }
}
