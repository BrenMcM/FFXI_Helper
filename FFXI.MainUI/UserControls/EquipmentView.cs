using EliteMMO.API;
using FFXI.MainUI.Controllers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class EquipmentView : UserControl
    {
        private InventoryItem _MainHand { get; set; }
        private InventoryItem _Sub { get; set; }
        private InventoryItem _Ranged { get; set; }
        private InventoryItem _Ammo { get; set; }
        private InventoryItem _Head { get; set; }
        private InventoryItem _Neck { get; set; }
        private InventoryItem _EarOne { get; set; }
        private InventoryItem _EarTwo { get; set; }
        private InventoryItem _Body { get; set; }
        private InventoryItem _Hands { get; set; }
        private InventoryItem _RingOne { get; set; }
        private InventoryItem _RingTwo { get; set; }
        private InventoryItem _Back { get; set; }
        private InventoryItem _Waist { get; set; }
        private InventoryItem _Legs { get; set; }
        private InventoryItem _Feet { get; set; }

        public EquipmentView()
        {
            InitializeComponent();
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateEquipment);
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateEquippedStats);            
        }
        public void UpdateEquipment(object sender, EventArgs args)
        {
            ApiController.NotUsed();

            _MainHand = GetSlotItem(EquipmentSlot.Main, pcbMainHand);
            _Sub = GetSlotItem(EquipmentSlot.Sub, pcbSub);
            _Ranged = GetSlotItem(EquipmentSlot.Range, pcbRanged);
            _Ammo = GetSlotItem(EquipmentSlot.Ammo, pcbAmmo);
            _Head = GetSlotItem(EquipmentSlot.Head, pcbHead);
            _Body = GetSlotItem(EquipmentSlot.Body, pcbBody);
            _Hands = GetSlotItem(EquipmentSlot.Hands, pcbHands);
            _Legs = GetSlotItem(EquipmentSlot.Legs, pcbLegs);
            _Neck = GetSlotItem(EquipmentSlot.Neck, pcbNeck);
            _Back = GetSlotItem(EquipmentSlot.Back, pcbBack);
            _Feet = GetSlotItem(EquipmentSlot.Feet, pcbFeet);
            _Waist = GetSlotItem(EquipmentSlot.Waist, pcbWaist);
            _EarOne = GetSlotItem(EquipmentSlot.Ear1, pcbEarOne);
            _EarTwo = GetSlotItem(EquipmentSlot.Ear2, pcbEarTwo);             
            _RingOne = GetSlotItem(EquipmentSlot.Ring1, pcbRingOne);
            _RingTwo = GetSlotItem(EquipmentSlot.Ring2, pcbRingTwo);            
        }

        public void UpdateEquippedStats(object sender, EventArgs args)
        {
            txtHp.Text = "+" + ApiController.GetStatsAddWithEquipment("HP", false);
            txtMp.Text = "+" + ApiController.GetStatsAddWithEquipment("MP", false);
            txtDmg.Text = "+" + ApiController.GetStatsAddWithEquipment("DMG:", false);
            txtDef.Text = "+" + ApiController.GetStatsAddWithEquipment("DEF:", false);

            txtStr.Text = "+" + ApiController.GetStatsAddWithEquipment("STR", false);
            txtVit.Text = "+" + ApiController.GetStatsAddWithEquipment("VIT", false);
            txtDex.Text = "+" + ApiController.GetStatsAddWithEquipment("DEX", false);
            txtAgi.Text = "+" + ApiController.GetStatsAddWithEquipment("AGI", false);
            txtInt.Text = "+" + ApiController.GetStatsAddWithEquipment("INT", false);
            txtMnd.Text = "+" + ApiController.GetStatsAddWithEquipment("MND", false);
            txtChr.Text = "+" + ApiController.GetStatsAddWithEquipment("CHR", false);

            txtEva.Text = "+" + ApiController.GetStatsAddWithEquipment("Evasion", false);
            txtAcc.Text = "+" + ApiController.GetStatsAddWithEquipment("Accuracy", false);

            txtHaste.Text = "+" + ApiController.GetStatsAddWithEquipment("Haste", true);
            txtFastCast.Text = "+" + ApiController.GetStatsAddWithEquipment("Fast Cast", true);
        }

        private InventoryItem GetSlotItem(EquipmentSlot slot, PictureBox display)
        {
            var inventoryItem = ApiController.GetEquippedItem(slot);
            var item = ApiController.GetItemInfo(inventoryItem.Id);
            if (item != null)
            {
                display.Image = GetIconImage(item);
                display.Tag = (int) inventoryItem.Id;
                display.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return inventoryItem;
        }

        public Image GetIconImage(IItem item)
        {
            if (item.Bitmap != null)
            {
                Bitmap bmp;
                using (var ms = new MemoryStream(item.Bitmap))
                {
                    bmp = new Bitmap(ms);
                }
                return bmp;
            }
            else
            {
                return null;
            }
        }

        private void EquipmentSlot_Click(object sender, EventArgs e)
        {
            var picBox = (PictureBox)sender;
            var itemId = (int)picBox.Tag;
            var item = ApiController.GetItemInfo(itemId);
            vwItems.LoadItem(item);
        }

        private void slot_MouseHover(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;            
        }

        private void slot_MouseLeave(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.None;
        }
    }
}
