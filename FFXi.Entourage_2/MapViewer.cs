using FFXi.Entourage_2.MapAI;
using FFXI.Entourage_2.Controllers;
using FFXI.Entourage_2.CustomEventArgs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FFXi.Entourage_2
{
    public partial class MapViewer : Form
    {
        private Graphics g { get; set; }
        public MapViewer()
        {
            InitializeComponent();
            //PaintGrid();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (cbxSelectPlayer.SelectedIndex >= 0)
            {
                int cellSize = 5;
                string memberName = (string)cbxSelectPlayer.SelectedItem;
                string mapName = MemberController.GetMember(memberName).PlayerZoneName;

                Graphics g = pnlCanvas.CreateGraphics();
                var grid = WorldMap.GetMapGrid(mapName);
                int squareValue = Math.Max(grid.GetLength(1), grid.GetLength(0));

                int canvasSizeH = this.Height;
                int canvasSizeW = this.Width;

                

                var memberPosition = MemberController.GetMember(memberName).PlayerCoordinates;
                //g.FillRectangle(Brushes.Red, (grid.GetLength(0)/2)*cellSize, (grid.GetLength(1)/2)*cellSize, cellSize, cellSize);
                
                for (int y = 0; y < squareValue; ++y)
                {
                    g.DrawLine(new Pen(Color.Red), 0, y * cellSize, squareValue * cellSize, y * cellSize);
                }

                for (int x = 0; x < squareValue; ++x)
                {
                    g.DrawLine(new Pen(Color.Red), x * cellSize, 0, x * cellSize, squareValue * cellSize);
                }

                for(int x=0; x< grid.GetLength(0); x++)
                {
                    for(int y=0; y < grid.GetLength(1); y++)
                    {
                        if (grid[x,y] == 1)
                        {
                            g.FillRectangle(Brushes.LightGreen, x * cellSize, y * cellSize, cellSize, cellSize);
                        }
                    }
                }

                lblGridSize.Text = $"Map Name: {mapName} | Grid Size: {squareValue} * {squareValue}";
            }
        }

        public void NewMemberAdded(string name)
        {
            cbxSelectPlayer.Items.Add(name);
        }

        public void MemberRemoved(object sender, MemberUpdateEventArgs args)
        {
            var strName = (string) cbxSelectPlayer.SelectedItem;
            if ( strName.Equals(args.MemberName))
            {
                cbxSelectPlayer.SelectedIndex = -1;
            }
            cbxSelectPlayer.Items.Remove(args.MemberName);
        }
    }
}
