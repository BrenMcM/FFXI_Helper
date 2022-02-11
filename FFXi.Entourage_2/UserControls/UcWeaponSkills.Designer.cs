
namespace FFXi.Entourage_2.UserControls
{
    partial class UcWeaponSkills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcWeaponSkills));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TcWeaponSkills = new System.Windows.Forms.TabControl();
            this.tpgAllMembers = new System.Windows.Forms.TabPage();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.TcWeaponSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TcWeaponSkills
            // 
            this.TcWeaponSkills.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TcWeaponSkills.Controls.Add(this.tpgAllMembers);
            this.TcWeaponSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcWeaponSkills.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TcWeaponSkills.ItemSize = new System.Drawing.Size(30, 120);
            this.TcWeaponSkills.Location = new System.Drawing.Point(0, 25);
            this.TcWeaponSkills.Multiline = true;
            this.TcWeaponSkills.Name = "TcWeaponSkills";
            this.TcWeaponSkills.SelectedIndex = 0;
            this.TcWeaponSkills.Size = new System.Drawing.Size(405, 279);
            this.TcWeaponSkills.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TcWeaponSkills.TabIndex = 2;
            this.TcWeaponSkills.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcWeaponSkills_DrawItem);
            // 
            // tpgAllMembers
            // 
            this.tpgAllMembers.Location = new System.Drawing.Point(124, 4);
            this.tpgAllMembers.Name = "tpgAllMembers";
            this.tpgAllMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAllMembers.Size = new System.Drawing.Size(277, 271);
            this.tpgAllMembers.TabIndex = 0;
            this.tpgAllMembers.Text = "All Members";
            this.tpgAllMembers.UseVisualStyleBackColor = true;
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
            // UcWeaponSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TcWeaponSkills);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UcWeaponSkills";
            this.Size = new System.Drawing.Size(405, 304);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TcWeaponSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl TcWeaponSkills;
        private System.Windows.Forms.TabPage tpgAllMembers;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
