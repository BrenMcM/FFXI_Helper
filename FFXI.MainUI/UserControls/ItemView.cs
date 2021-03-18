using EliteMMO.API;
using FFXI.MainUI.Controllers;
using FFXI.MainUI.Entities;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class ItemView : UserControl
    {
        public ItemView()
        {
            InitializeComponent();
        }

        public void LoadItem(PlayerItem pItem)
        {
            var item = ApiController.GetItemInfo(pItem.ItemId);
            LoadItem(item);

        }

        public void LoadItem(IItem item) 
        {
            lblItemName.Text = item.Name[0];

            if (item.Level > 0 && item.ItemLevel <= 0)
            {
                lblLevel.Text = "Lv: " + item.Level;
            }
            else if (item.ItemLevel > 0)
            {
                lblLevel.Text = "iLv: " + item.ItemLevel;
            }
            else lblLevel.Hide();

            if (item.SuperiorLevel > 0)
            {
                lblSuperLevel.Text = "Su: " + item.SuperiorLevel;
            }
            else lblSuperLevel.Hide();

            if (!string.IsNullOrWhiteSpace(item.Description[0]))
            {
                if (item.ItemType == (int)ItemType.Armor || item.ItemType == (int)ItemType.Weapon)
                {
                    txtItemDescription1.Text = ApiController
                        .FixEquipmentDescription(item.Description[0]);
                }
                else
                {
                    txtItemDescription1.Text = item.Description[0];
                }
            }
            else txtItemDescription1.Hide();            

            pcbIcon.Image = GetIconImage(item);
            pcbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Image GetIconImage(IItem item)
        {
            Bitmap bmp;
            using (var ms = new MemoryStream(item.Bitmap))
            {
                bmp = new Bitmap(ms);
            }

            return bmp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
