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
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpShadowBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShadowBox
            // 
            this.grpShadowBox.Controls.Add(this.btnStop);
            this.grpShadowBox.Controls.Add(this.btnStart);
            this.grpShadowBox.Controls.Add(this.chkBattleOnly);
            this.grpShadowBox.Controls.Add(this.checkBox3);
            this.grpShadowBox.Controls.Add(this.checkBox2);
            this.grpShadowBox.Controls.Add(this.checkBox1);
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
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Utsusemi: San";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Utsusemi: Ni";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Utsusemi: Ichi";
            this.checkBox1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
