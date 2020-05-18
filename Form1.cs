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
            AddGridLables();
        }

        private void InitializeGrid()
        {
            this.Width = 600;
            this.Height = 600;
            Grid.BackColor = Color.LightSteelBlue;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            //Webdings font
            //e, d, k, b, N, !, &, $  
        }

        private void AddGridLables()
        {
            Label label;
            for (int c = 0; c < 4; c++)
            {
                for (int r = 0; r < 4; r++)
                {
                    label = new Label
                    {
                        Dock = DockStyle.Fill,
                        ForeColor = Color.Black,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Webdings", 72, FontStyle.Bold),
                        Text = "e"

                    };
                    Grid.Controls.Add(label, c, r);
                }
            }
        }

    }
}
