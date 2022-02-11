using FFXI.Entourage_2.Controllers;
using FFXI.Entourage_2.CustomEventArgs;
using FFXI.Entourage_2.Entities;
using FFXI.Entourage_2.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FFXI.Entourage_2.UserControls
{
    public partial class UcInventories : UserControl
    {
        public UcInventories()
        {
            InitializeComponent();
            
        }

        public void MemberAddedEventHandler(object sender, MemberUpdateEventArgs args)
        {
            foreach (TabPage tab in TcInventories.TabPages)
            {
                if (tab.Name == args.MemberName)
                {
                    return;
                }
            }

            CreateMemberPage(args.MemberName);
        }

        public void MemberRemovedEventHandler(object sender, MemberUpdateEventArgs args)
        {
            foreach (TabPage tab in TcInventories.TabPages)
            {
                if (tab.Name == args.MemberName)
                {
                    TcInventories.TabPages.Remove(tab);
                }
            }
        }

        private void CreateMemberPage(string name)
        {
            var newPage = new TabPage();
            var inventory = new UcMemberInventory();
            inventory.Dock = DockStyle.Fill;
            newPage.Name = name;
            newPage.Text = name;
            newPage.Controls.Add(inventory);
            TcInventories.TabPages.Add(newPage);
        }

        private void tcInventories_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.TcInventories.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.TcInventories.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.TcInventories.Font, Brushes.Black, x, y);
        }

        public void LoadContainerItemsForAll(object sender, EventArgs args)
        {
            if (MemberController.Members.Count > 0)
            {
                Dictionary<int, PlayerItem> InventoryItems = new Dictionary<int, PlayerItem>();
                foreach (var member in MemberController.Members)
                {
                    foreach (var container in Enum.GetValues(typeof(ItemContainerType)))
                    {

                        foreach (var item in  member.Value.GetContainerItems((int)container))
                        {
                            PlayerItem temp;
                            if (!InventoryItems.TryGetValue(item.ItemId, out temp))
                            {
                                InventoryItems.Add(item.ItemId, item);
                            }
                            else
                            {
                                InventoryItems[item.ItemId].Count += item.Count;
                            }
                        }
                    }
                }

                var ds = fillDataSet(InventoryItems);
                BindingSource bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                dgvAllMembers.DataSource = bs;
                dgvAllMembers.AutoResizeColumns();
            }
        }

        public DataSet fillDataSet(Dictionary<int, PlayerItem> items)
        {
            DataSet ds = new DataSet();
            DataTable tbl = new DataTable();
            ds.Tables.Add(tbl);
            tbl.Columns.Add("Id");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Amount");
            foreach(var item in items)
            {
                DataRow dr = tbl.Rows.Add();

                if (item.Value == null)
                {
                    dr.SetField("Id", item.Key);
                    dr.SetField("Name", $"Unknow_{item.Key}");
                    dr.SetField("Amount", 0);
                }
                else
                {
                    dr.SetField("Id", item.Value.ItemId);
                    dr.SetField("Name", item.Value.Name);
                    dr.SetField("Amount", item.Value.Count);
                }
            }
            return ds;
        }

        public void HandlePartyMemberClosedEvent(object sender, MemberUpdateEventArgs args)
        {
            foreach(TabPage page in TcInventories.TabPages)
            {
                if (page.Name.Equals(args.MemberName))
                {
                    TcInventories.TabPages.Remove(page);
                }
            }
        }            
    }
}
