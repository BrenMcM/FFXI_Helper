using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXi.Entourage_2.UserControls
{
    public partial class UsSpells : UserControl
    {
        public UsSpells()
        {
            InitializeComponent();
        }

        private void tcSpells_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.TcSpells.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.TcSpells.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.TcSpells.Font, Brushes.Black, x, y);
        }
    }
}
