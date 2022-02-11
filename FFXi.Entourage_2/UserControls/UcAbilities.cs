﻿using System.Drawing;
using System.Windows.Forms;

namespace FFXi.Entourage_2.UserControls
{
    public partial class UcAbilities : UserControl
    {
        public UcAbilities()
        {
            InitializeComponent();
        }

        private void tcAbilities_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.TcAbilities.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.TcAbilities.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.TcAbilities.Font, Brushes.Black, x, y);
        }
    }
}
