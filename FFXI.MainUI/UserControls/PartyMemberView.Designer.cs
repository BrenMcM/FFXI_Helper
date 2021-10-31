namespace FFXI.MainUI.UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.prgbHP = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prgbMP = new System.Windows.Forms.ProgressBar();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.prgbMP);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Controls.Add(this.prgbHP);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(189, 95);
            this.grpMember.TabIndex = 0;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Name";
            // 
            // prgbHP
            // 
            this.prgbHP.Location = new System.Drawing.Point(39, 24);
            this.prgbHP.Name = "prgbHP";
            this.prgbHP.Size = new System.Drawing.Size(128, 13);
            this.prgbHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbHP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MP";
            // 
            // prgbMP
            // 
            this.prgbMP.Location = new System.Drawing.Point(39, 50);
            this.prgbMP.Name = "prgbMP";
            this.prgbMP.Size = new System.Drawing.Size(128, 13);
            this.prgbMP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbMP.TabIndex = 5;
            // 
            // PartyMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMember);
            this.Name = "PartyMemberView";
            this.Size = new System.Drawing.Size(189, 95);
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.ProgressBar prgbHP;
        private System.Windows.Forms.ProgressBar prgbMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
