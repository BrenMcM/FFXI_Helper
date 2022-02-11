using System.Drawing;
using System.Windows.Forms;

namespace FFXi.Entourage_2.UserControls
{
    public partial class UcWeaponSkills : UserControl
    {
        public UcWeaponSkills()
        {
            InitializeComponent();
        }

        private void tcWeaponSkills_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.TcWeaponSkills.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.TcWeaponSkills.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.TcWeaponSkills.Font, Brushes.Black, x, y);
        }
    }
}
