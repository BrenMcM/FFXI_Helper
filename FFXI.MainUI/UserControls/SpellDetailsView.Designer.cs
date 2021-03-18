
namespace FFXI.MainUI.UserControls
{
    partial class SpellDetailsView
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
            this.lblSpellIcon = new System.Windows.Forms.PictureBox();
            this.lblSpellName = new System.Windows.Forms.Label();
            this.txtSpellDescription = new System.Windows.Forms.TextBox();
            this.lblMagicType = new System.Windows.Forms.Label();
            this.txtMagicType = new System.Windows.Forms.TextBox();
            this.txtSpellElement = new System.Windows.Forms.TextBox();
            this.lblMagicElement = new System.Windows.Forms.Label();
            this.lblMpCost = new System.Windows.Forms.Label();
            this.txtMpCost = new System.Windows.Forms.TextBox();
            this.txtCastTime = new System.Windows.Forms.TextBox();
            this.lblCastTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpellIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpellIcon
            // 
            this.lblSpellIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpellIcon.Location = new System.Drawing.Point(3, 3);
            this.lblSpellIcon.Name = "lblSpellIcon";
            this.lblSpellIcon.Size = new System.Drawing.Size(104, 76);
            this.lblSpellIcon.TabIndex = 0;
            this.lblSpellIcon.TabStop = false;
            // 
            // lblSpellName
            // 
            this.lblSpellName.AutoSize = true;
            this.lblSpellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpellName.Location = new System.Drawing.Point(113, 31);
            this.lblSpellName.Name = "lblSpellName";
            this.lblSpellName.Size = new System.Drawing.Size(134, 29);
            this.lblSpellName.TabIndex = 1;
            this.lblSpellName.Text = "SpellName";
            // 
            // txtSpellDescription
            // 
            this.txtSpellDescription.Location = new System.Drawing.Point(3, 85);
            this.txtSpellDescription.Multiline = true;
            this.txtSpellDescription.Name = "txtSpellDescription";
            this.txtSpellDescription.ReadOnly = true;
            this.txtSpellDescription.Size = new System.Drawing.Size(387, 97);
            this.txtSpellDescription.TabIndex = 2;
            // 
            // lblMagicType
            // 
            this.lblMagicType.AutoSize = true;
            this.lblMagicType.Location = new System.Drawing.Point(0, 197);
            this.lblMagicType.Name = "lblMagicType";
            this.lblMagicType.Size = new System.Drawing.Size(85, 17);
            this.lblMagicType.TabIndex = 3;
            this.lblMagicType.Text = "Magic Type:";
            // 
            // txtMagicType
            // 
            this.txtMagicType.Location = new System.Drawing.Point(118, 194);
            this.txtMagicType.Name = "txtMagicType";
            this.txtMagicType.ReadOnly = true;
            this.txtMagicType.Size = new System.Drawing.Size(272, 22);
            this.txtMagicType.TabIndex = 4;
            // 
            // txtSpellElement
            // 
            this.txtSpellElement.Location = new System.Drawing.Point(118, 222);
            this.txtSpellElement.Name = "txtSpellElement";
            this.txtSpellElement.ReadOnly = true;
            this.txtSpellElement.Size = new System.Drawing.Size(272, 22);
            this.txtSpellElement.TabIndex = 5;
            // 
            // lblMagicElement
            // 
            this.lblMagicElement.AutoSize = true;
            this.lblMagicElement.Location = new System.Drawing.Point(0, 225);
            this.lblMagicElement.Name = "lblMagicElement";
            this.lblMagicElement.Size = new System.Drawing.Size(104, 17);
            this.lblMagicElement.TabIndex = 6;
            this.lblMagicElement.Text = "Magic Element:";
            // 
            // lblMpCost
            // 
            this.lblMpCost.AutoSize = true;
            this.lblMpCost.Location = new System.Drawing.Point(0, 253);
            this.lblMpCost.Name = "lblMpCost";
            this.lblMpCost.Size = new System.Drawing.Size(64, 17);
            this.lblMpCost.TabIndex = 7;
            this.lblMpCost.Text = "MP Cost:";
            // 
            // txtMpCost
            // 
            this.txtMpCost.Location = new System.Drawing.Point(118, 250);
            this.txtMpCost.Name = "txtMpCost";
            this.txtMpCost.ReadOnly = true;
            this.txtMpCost.Size = new System.Drawing.Size(272, 22);
            this.txtMpCost.TabIndex = 8;
            // 
            // txtCastTime
            // 
            this.txtCastTime.Location = new System.Drawing.Point(118, 278);
            this.txtCastTime.Name = "txtCastTime";
            this.txtCastTime.ReadOnly = true;
            this.txtCastTime.Size = new System.Drawing.Size(272, 22);
            this.txtCastTime.TabIndex = 9;
            // 
            // lblCastTime
            // 
            this.lblCastTime.AutoSize = true;
            this.lblCastTime.Location = new System.Drawing.Point(0, 281);
            this.lblCastTime.Name = "lblCastTime";
            this.lblCastTime.Size = new System.Drawing.Size(75, 17);
            this.lblCastTime.TabIndex = 10;
            this.lblCastTime.Text = "Cast Time:";
            // 
            // SpellDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCastTime);
            this.Controls.Add(this.txtCastTime);
            this.Controls.Add(this.txtMpCost);
            this.Controls.Add(this.lblMpCost);
            this.Controls.Add(this.lblMagicElement);
            this.Controls.Add(this.txtSpellElement);
            this.Controls.Add(this.txtMagicType);
            this.Controls.Add(this.lblMagicType);
            this.Controls.Add(this.txtSpellDescription);
            this.Controls.Add(this.lblSpellName);
            this.Controls.Add(this.lblSpellIcon);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SpellDetailsView";
            this.Size = new System.Drawing.Size(393, 377);
            ((System.ComponentModel.ISupportInitialize)(this.lblSpellIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblSpellIcon;
        private System.Windows.Forms.Label lblSpellName;
        private System.Windows.Forms.TextBox txtSpellDescription;
        private System.Windows.Forms.Label lblMagicType;
        private System.Windows.Forms.TextBox txtMagicType;
        private System.Windows.Forms.TextBox txtSpellElement;
        private System.Windows.Forms.Label lblMagicElement;
        private System.Windows.Forms.Label lblMpCost;
        private System.Windows.Forms.TextBox txtMpCost;
        private System.Windows.Forms.TextBox txtCastTime;
        private System.Windows.Forms.Label lblCastTime;
    }
}
