using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            FillTheGrid();
        }

        private void InitializeGrid()
        {
            this.Width = 400;
            this.Height = 400;
            Grid.BackColor = Color.LightSteelBlue;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        }

        private void FillTheGrid()
        {
            Label label;

            for(int c = 0; c < 4; c++)
            {
                for(int r = 0; r < 4; r++)
                {
                    label = new Label
                    {
                        Dock = DockStyle.Fill,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Font = new Font("Roboto", 72)
                    };

                    Grid.Controls.Add(label, c, r);
                }
            }            
        }
    }
}
