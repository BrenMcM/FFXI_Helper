
namespace FFXI.MainUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxProcesses = new System.Windows.Forms.ToolStripComboBox();
            this.btnSelectPlayer = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainStatus = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpgPlayerDetails = new System.Windows.Forms.TabPage();
            this.playerDetailsView1 = new FFXI.MainUI.UserControls.PlayerDetailsView();
            this.tpgInventory = new System.Windows.Forms.TabPage();
            this.tpgPlayerSpells = new System.Windows.Forms.TabPage();
            this.vwPlayerSpells = new FFXI.MainUI.UserControls.SpellsView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.equipmentView1 = new FFXI.MainUI.UserControls.EquipmentView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.shadowCaster1 = new FFXI.MainUI.UserControls.Ninja.ShadowCaster();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpgPlayerDetails.SuspendLayout();
            this.tpgPlayerSpells.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbxProcesses,
            this.btnSelectPlayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 25);
            this.toolStripLabel1.Text = "Player";
            // 
            // cbxProcesses
            // 
            this.cbxProcesses.Name = "cbxProcesses";
            this.cbxProcesses.Size = new System.Drawing.Size(160, 28);
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPlayer.Image")));
            this.btnSelectPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(97, 25);
            this.btnSelectPlayer.Text = "Select Player";
            this.btnSelectPlayer.Click += new System.EventHandler(this.btnSelectPlayer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMainStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 574);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1067, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblMainStatus
            // 
            this.lblMainStatus.BackColor = System.Drawing.Color.Red;
            this.lblMainStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMainStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainStatus.Location = new System.Drawing.Point(2, 2);
            this.lblMainStatus.Name = "lblMainStatus";
            this.lblMainStatus.Size = new System.Drawing.Size(217, 39);
            this.lblMainStatus.TabIndex = 0;
            this.lblMainStatus.Text = "Disconnected";
            this.lblMainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpgPlayerDetails);
            this.tcMain.Controls.Add(this.tpgInventory);
            this.tcMain.Controls.Add(this.tpgPlayerSpells);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Enabled = false;
            this.tcMain.Location = new System.Drawing.Point(0, 28);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1067, 546);
            this.tcMain.TabIndex = 2;
            // 
            // tpgPlayerDetails
            // 
            this.tpgPlayerDetails.Controls.Add(this.playerDetailsView1);
            this.tpgPlayerDetails.Location = new System.Drawing.Point(4, 25);
            this.tpgPlayerDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tpgPlayerDetails.Name = "tpgPlayerDetails";
            this.tpgPlayerDetails.Padding = new System.Windows.Forms.Padding(4);
            this.tpgPlayerDetails.Size = new System.Drawing.Size(1059, 517);
            this.tpgPlayerDetails.TabIndex = 0;
            this.tpgPlayerDetails.Text = "Player Details";
            this.tpgPlayerDetails.UseVisualStyleBackColor = true;
            // 
            // playerDetailsView1
            // 
            this.playerDetailsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerDetailsView1.Location = new System.Drawing.Point(4, 4);
            this.playerDetailsView1.Name = "playerDetailsView1";
            this.playerDetailsView1.Size = new System.Drawing.Size(1051, 509);
            this.playerDetailsView1.TabIndex = 0;
            // 
            // tpgInventory
            // 
            this.tpgInventory.Location = new System.Drawing.Point(4, 25);
            this.tpgInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tpgInventory.Name = "tpgInventory";
            this.tpgInventory.Padding = new System.Windows.Forms.Padding(4);
            this.tpgInventory.Size = new System.Drawing.Size(1059, 517);
            this.tpgInventory.TabIndex = 1;
            this.tpgInventory.Text = "Inventory";
            this.tpgInventory.UseVisualStyleBackColor = true;
            // 
            // tpgPlayerSpells
            // 
            this.tpgPlayerSpells.Controls.Add(this.vwPlayerSpells);
            this.tpgPlayerSpells.Location = new System.Drawing.Point(4, 25);
            this.tpgPlayerSpells.Name = "tpgPlayerSpells";
            this.tpgPlayerSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPlayerSpells.Size = new System.Drawing.Size(1059, 517);
            this.tpgPlayerSpells.TabIndex = 2;
            this.tpgPlayerSpells.Text = "Magic Spells";
            this.tpgPlayerSpells.UseVisualStyleBackColor = true;
            // 
            // vwPlayerSpells
            // 
            this.vwPlayerSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vwPlayerSpells.Location = new System.Drawing.Point(3, 3);
            this.vwPlayerSpells.Name = "vwPlayerSpells";
            this.vwPlayerSpells.Size = new System.Drawing.Size(1053, 511);
            this.vwPlayerSpells.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.equipmentView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 517);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Equipment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // equipmentView1
            // 
            this.equipmentView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentView1.Location = new System.Drawing.Point(3, 3);
            this.equipmentView1.Name = "equipmentView1";
            this.equipmentView1.Padding = new System.Windows.Forms.Padding(10);
            this.equipmentView1.Size = new System.Drawing.Size(1053, 511);
            this.equipmentView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shadowCaster1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 517);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Ninja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // shadowCaster1
            // 
            this.shadowCaster1.Location = new System.Drawing.Point(8, 6);
            this.shadowCaster1.Name = "shadowCaster1";
            this.shadowCaster1.Size = new System.Drawing.Size(334, 127);
            this.shadowCaster1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 617);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpgPlayerDetails.ResumeLayout(false);
            this.tpgPlayerSpells.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxProcesses;
        private System.Windows.Forms.ToolStripButton btnSelectPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainStatus;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpgPlayerDetails;
        private System.Windows.Forms.TabPage tpgInventory;
        private UserControls.InventoryView InventoryView;
        private UserControls.PlayerDetailsView playerDetailsView1;
        private System.Windows.Forms.TabPage tpgPlayerSpells;
        private UserControls.SpellsView vwPlayerSpells;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.EquipmentView equipmentView1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.Ninja.ShadowCaster shadowCaster1;
    }
}

