
namespace FFXI.Entourage_2.UserControls
{
    partial class UcMemberInventory
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
            this.cbxInventoryList = new System.Windows.Forms.ComboBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxInventoryList
            // 
            this.cbxInventoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxInventoryList.FormattingEnabled = true;
            this.cbxInventoryList.Location = new System.Drawing.Point(0, 0);
            this.cbxInventoryList.Name = "cbxInventoryList";
            this.cbxInventoryList.Size = new System.Drawing.Size(129, 21);
            this.cbxInventoryList.TabIndex = 0;
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.AllowUserToOrderColumns = true;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 21);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.Size = new System.Drawing.Size(129, 224);
            this.dgvMember.TabIndex = 1;
            // 
            // UcMemberInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.cbxInventoryList);
            this.Name = "UcMemberInventory";
            this.Size = new System.Drawing.Size(129, 245);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxInventoryList;
        private System.Windows.Forms.DataGridView dgvMember;
    }
}
