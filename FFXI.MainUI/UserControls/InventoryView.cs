using FFXI.MainUI.Controllers;
using FFXI.MainUI.Entities;
using FFXI.MainUI.Enums;
using FFXI.MainUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FFXI.MainUI.UserControls
{
    public partial class InventoryView : UserControl
    {
        public InventoryView()
        {
            InitializeComponent();
            LoadInventoryNames();
        }

        public void UpdateView()
        {
            if (!ApiController.IsNULL())
            {

            }
        }

        private void LoadInventoryNames()
        {
            List<ListItem> items = new List<ListItem>();
            foreach (ItemContainerType it in (ItemContainerType[])Enum.GetValues(typeof(ItemContainerType)))
            {
                var item = new ListItem()
                {
                    Label = Enum.GetName(typeof(ItemContainerType), (int)it),
                    Value = (int)it
                };
                items.Add(item);
            }
            lsbInventories.DataSource = items;
            lsbInventories.DisplayMember = "Label";
            lsbInventories.ValueMember = "Value";
        }       

        private void lsbInventories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ApiController.IsNULL())
            {
                var containerId = (int)lsbInventories.SelectedValue;
                var items = InventoryController.GetContainerItems(containerId);
                lsbItems.DataSource = items;
                lsbItems.ValueMember = "ItemId";
                lsbItems.DisplayMember = "Name";
            }
        }

        private void lsbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (PlayerItem)lsbItems.SelectedItem;
            vwInventoryItem.LoadItem(item);
        }
    }
}
