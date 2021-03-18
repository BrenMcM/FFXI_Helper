
namespace FFXI.MainUI.UserControls
{
    partial class InventoryView
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
            this.lsbInventories = new System.Windows.Forms.ListBox();
            this.vwInventoryItem = new FFXI.MainUI.UserControls.ItemView();
            this.lsbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbInventories
            // 
            this.lsbInventories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbInventories.FormattingEnabled = true;
            this.lsbInventories.ItemHeight = 16;
            this.lsbInventories.Location = new System.Drawing.Point(7, 6);
            this.lsbInventories.Margin = new System.Windows.Forms.Padding(4);
            this.lsbInventories.Name = "lsbInventories";
            this.lsbInventories.Size = new System.Drawing.Size(192, 435);
            this.lsbInventories.TabIndex = 0;
            this.lsbInventories.SelectedIndexChanged += new System.EventHandler(this.lsbInventories_SelectedIndexChanged);
            // 
            // vwInventoryItem
            // 
            this.vwInventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vwInventoryItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.vwInventoryItem.Location = new System.Drawing.Point(534, 6);
            this.vwInventoryItem.Margin = new System.Windows.Forms.Padding(5);
            this.vwInventoryItem.Name = "vwInventoryItem";
            this.vwInventoryItem.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.vwInventoryItem.Size = new System.Drawing.Size(339, 435);
            this.vwInventoryItem.TabIndex = 1;
            // 
            // lsbItems
            // 
            this.lsbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbItems.FormattingEnabled = true;
            this.lsbItems.ItemHeight = 16;
            this.lsbItems.Location = new System.Drawing.Point(199, 6);
            this.lsbItems.Name = "lsbItems";
            this.lsbItems.Size = new System.Drawing.Size(335, 435);
            this.lsbItems.TabIndex = 2;
            this.lsbItems.SelectedIndexChanged += new System.EventHandler(this.lsbItems_SelectedIndexChanged);
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsbItems);
            this.Controls.Add(this.vwInventoryItem);
            this.Controls.Add(this.lsbInventories);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryView";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(880, 447);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbInventories;
        private ItemView vwInventoryItem;
        private System.Windows.Forms.ListBox lsbItems;
    }
}
