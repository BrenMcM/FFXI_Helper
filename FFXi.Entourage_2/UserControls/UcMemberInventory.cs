using FFXI.Entourage_2.Controllers;
using FFXI.Entourage_2.Entities;
using FFXI.Entourage_2.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FFXI.Entourage_2.UserControls
{
    public partial class UcMemberInventory : UserControl
    {
        private DataTable CurrentTableData;
        private string MemberName { get; set; }
        public UcMemberInventory()
        {
            InitializeComponent();
            LoadContainerNames();
        }

        private void LoadContainerItems()
        {
            var member = MemberController.GetMember(MemberName);
            Dictionary<int, PlayerItem> InventoryItems = new Dictionary<int, PlayerItem>();
            foreach (var container in Enum.GetValues(typeof(ItemContainerType)))
            {
                foreach (var item in member.GetContainerItems((int)container))
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

            var ds = fillDataSet(InventoryItems);
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dgvMember.DataSource = bs;
            dgvMember.AutoResizeColumns();
        }

        private void LoadContainerNames()
        {
            cbxInventoryList.DataSource = Enum.GetValues(typeof(ItemContainerType));
        }

        private DataSet fillDataSet(Dictionary<int, PlayerItem> items)
        {
            DataSet ds = new DataSet();
            DataTable tbl = new DataTable();
            ds.Tables.Add(tbl);
            tbl.Columns.Add("Id");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Amount");
            foreach (var item in items)
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
    }
}
