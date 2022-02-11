
namespace FFXI.Entourage_2
{
    partial class PartyMemberView
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
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblZone = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCoords = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.ucMemberBuffs = new FFXi.Entourage_2.UserControls.UcMemberBuffs();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(704, 21);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Player Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblZone);
            this.panel2.Controls.Add(this.lblJob);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 31);
            this.panel2.TabIndex = 13;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(139, 8);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(32, 13);
            this.lblZone.TabIndex = 3;
            this.lblZone.Text = "Zone";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(12, 8);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(48, 13);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Job/Sub";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCoords);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 29);
            this.panel1.TabIndex = 14;
            // 
            // lblCoords
            // 
            this.lblCoords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCoords.Location = new System.Drawing.Point(71, 0);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(633, 29);
            this.lblCoords.TabIndex = 4;
            this.lblCoords.Text = "Coords";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 29);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblTP);
            this.pnlStatus.Controls.Add(this.lblMP);
            this.pnlStatus.Controls.Add(this.lblHP);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(0, 52);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(235, 88);
            this.pnlStatus.TabIndex = 16;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(13, 63);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(21, 13);
            this.lblTP.TabIndex = 3;
            this.lblTP.Text = "TP";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(13, 30);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(23, 13);
            this.lblMP.TabIndex = 5;
            this.lblMP.Text = "MP";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(13, 11);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "HP";
            // 
            // ucMemberBuffs
            // 
            this.ucMemberBuffs.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucMemberBuffs.Location = new System.Drawing.Point(489, 52);
            this.ucMemberBuffs.MemberName = "";
            this.ucMemberBuffs.Name = "ucMemberBuffs";
            this.ucMemberBuffs.Size = new System.Drawing.Size(215, 88);
            this.ucMemberBuffs.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(235, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 88);
            this.panel3.TabIndex = 19;
            // 
            // PartyMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucMemberBuffs);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblName);
            this.Name = "PartyMemberView";
            this.Size = new System.Drawing.Size(704, 169);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoords;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblHP;
        private FFXi.Entourage_2.UserControls.UcMemberBuffs ucMemberBuffs;
        private System.Windows.Forms.Panel panel3;
    }
}