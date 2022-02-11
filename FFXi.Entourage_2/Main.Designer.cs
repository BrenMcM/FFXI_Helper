
namespace FFXI.Entourage_2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewMap = new System.Windows.Forms.ToolStripButton();
            this.TcMembersDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMembersBoard = new System.Windows.Forms.Panel();
            this.UcInventories = new FFXI.Entourage_2.UserControls.UcInventories();
            this.ucAbilities = new FFXi.Entourage_2.UserControls.UcAbilities();
            this.usSpells = new FFXi.Entourage_2.UserControls.UsSpells();
            this.ucWeaponSkills = new FFXi.Entourage_2.UserControls.UcWeaponSkills();
            this.toolStrip1.SuspendLayout();
            this.TcMembersDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMember,
            this.toolStripSeparator1,
            this.btnViewMap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1170, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(97, 22);
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnViewMap
            // 
            this.btnViewMap.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMap.Image")));
            this.btnViewMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewMap.Name = "btnViewMap";
            this.btnViewMap.Size = new System.Drawing.Size(104, 22);
            this.btnViewMap.Text = "View Map Grid";
            this.btnViewMap.Click += new System.EventHandler(this.btnViewMap_Click);
            // 
            // TcMembersDetails
            // 
            this.TcMembersDetails.Controls.Add(this.tabPage1);
            this.TcMembersDetails.Controls.Add(this.tabPage2);
            this.TcMembersDetails.Controls.Add(this.tabPage3);
            this.TcMembersDetails.Controls.Add(this.tabPage4);
            this.TcMembersDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.TcMembersDetails.Location = new System.Drawing.Point(0, 25);
            this.TcMembersDetails.Name = "TcMembersDetails";
            this.TcMembersDetails.SelectedIndex = 0;
            this.TcMembersDetails.Size = new System.Drawing.Size(407, 517);
            this.TcMembersDetails.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UcInventories);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucAbilities);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(399, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abilities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.usSpells);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(399, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spells";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucWeaponSkills);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(399, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "WeaponSkills";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(407, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 100);
            this.panel1.TabIndex = 5;
            // 
            // pnlMembersBoard
            // 
            this.pnlMembersBoard.AutoScroll = true;
            this.pnlMembersBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMembersBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembersBoard.Location = new System.Drawing.Point(407, 25);
            this.pnlMembersBoard.Name = "pnlMembersBoard";
            this.pnlMembersBoard.Size = new System.Drawing.Size(763, 417);
            this.pnlMembersBoard.TabIndex = 6;
            // 
            // UcInventories
            // 
            this.UcInventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcInventories.Location = new System.Drawing.Point(3, 3);
            this.UcInventories.Name = "UcInventories";
            this.UcInventories.Size = new System.Drawing.Size(393, 485);
            this.UcInventories.TabIndex = 4;
            // 
            // ucAbilities
            // 
            this.ucAbilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAbilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbilities.Location = new System.Drawing.Point(3, 3);
            this.ucAbilities.Name = "ucAbilities";
            this.ucAbilities.Size = new System.Drawing.Size(393, 485);
            this.ucAbilities.TabIndex = 0;
            // 
            // usSpells
            // 
            this.usSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usSpells.Location = new System.Drawing.Point(3, 3);
            this.usSpells.Name = "usSpells";
            this.usSpells.Size = new System.Drawing.Size(393, 485);
            this.usSpells.TabIndex = 0;
            // 
            // ucWeaponSkills
            // 
            this.ucWeaponSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWeaponSkills.Location = new System.Drawing.Point(3, 3);
            this.ucWeaponSkills.Name = "ucWeaponSkills";
            this.ucWeaponSkills.Size = new System.Drawing.Size(393, 485);
            this.ucWeaponSkills.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 542);
            this.Controls.Add(this.pnlMembersBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TcMembersDetails);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TcMembersDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddMember;
        private System.Windows.Forms.TabControl TcMembersDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.UcInventories UcInventories;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnViewMap;
        private System.Windows.Forms.TabPage tabPage4;
        private FFXi.Entourage_2.UserControls.UcAbilities ucAbilities;
        private FFXi.Entourage_2.UserControls.UsSpells usSpells;
        private FFXi.Entourage_2.UserControls.UcWeaponSkills ucWeaponSkills;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMembersBoard;
    }
}

