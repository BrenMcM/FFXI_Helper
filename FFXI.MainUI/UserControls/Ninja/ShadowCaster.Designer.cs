namespace FFXI.MainUI.UserControls.Ninja
{
    partial class ShadowCaster
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
            this.grpShadowBox = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkBattleOnly = new System.Windows.Forms.CheckBox();
            this.chkSan = new System.Windows.Forms.CheckBox();
            this.chkNi = new System.Windows.Forms.CheckBox();
            this.chkIchi = new System.Windows.Forms.CheckBox();
            this.grpShadowBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShadowBox
            // 
            this.grpShadowBox.Controls.Add(this.btnStop);
            this.grpShadowBox.Controls.Add(this.btnStart);
            this.grpShadowBox.Controls.Add(this.chkBattleOnly);
            this.grpShadowBox.Controls.Add(this.chkSan);
            this.grpShadowBox.Controls.Add(this.chkNi);
            this.grpShadowBox.Controls.Add(this.chkIchi);
            this.grpShadowBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShadowBox.Location = new System.Drawing.Point(0, 0);
            this.grpShadowBox.Name = "grpShadowBox";
            this.grpShadowBox.Size = new System.Drawing.Size(334, 127);
            this.grpShadowBox.TabIndex = 0;
            this.grpShadowBox.TabStop = false;
            this.grpShadowBox.Text = "Shadow Caster";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(233, 69);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 50);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 50);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkBattleOnly
            // 
            this.chkBattleOnly.AutoSize = true;
            this.chkBattleOnly.Location = new System.Drawing.Point(6, 99);
            this.chkBattleOnly.Name = "chkBattleOnly";
            this.chkBattleOnly.Size = new System.Drawing.Size(136, 20);
            this.chkBattleOnly.TabIndex = 3;
            this.chkBattleOnly.Text = "Cast Only In Battle";
            this.chkBattleOnly.UseVisualStyleBackColor = true;
            // 
            // chkSan
            // 
            this.chkSan.AutoSize = true;
            this.chkSan.Location = new System.Drawing.Point(6, 73);
            this.chkSan.Name = "chkSan";
            this.chkSan.Size = new System.Drawing.Size(115, 20);
            this.chkSan.TabIndex = 2;
            this.chkSan.Text = "Utsusemi: San";
            this.chkSan.UseVisualStyleBackColor = true;
            // 
            // chkNi
            // 
            this.chkNi.AutoSize = true;
            this.chkNi.Location = new System.Drawing.Point(6, 47);
            this.chkNi.Name = "chkNi";
            this.chkNi.Size = new System.Drawing.Size(104, 20);
            this.chkNi.TabIndex = 1;
            this.chkNi.Text = "Utsusemi: Ni";
            this.chkNi.UseVisualStyleBackColor = true;
            // 
            // chkIchi
            // 
            this.chkIchi.AutoSize = true;
            this.chkIchi.Location = new System.Drawing.Point(6, 21);
            this.chkIchi.Name = "chkIchi";
            this.chkIchi.Size = new System.Drawing.Size(111, 20);
            this.chkIchi.TabIndex = 0;
            this.chkIchi.Text = "Utsusemi: Ichi";
            this.chkIchi.UseVisualStyleBackColor = true;
            // 
            // ShadowCaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpShadowBox);
            this.Name = "ShadowCaster";
            this.Size = new System.Drawing.Size(334, 127);
            this.grpShadowBox.ResumeLayout(false);
            this.grpShadowBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShadowBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkBattleOnly;
        private System.Windows.Forms.CheckBox chkSan;
        private System.Windows.Forms.CheckBox chkNi;
        private System.Windows.Forms.CheckBox chkIchi;
    }
}
