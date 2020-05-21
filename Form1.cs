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

        Random rand = new Random();
        List<string> icons = null;
        Label labelOne = null;
        Label labelTwo = null;

        public Form1()
        {
            InitializeComponent();
            InitializeIconsList();
            InitializeGrid();
            AddGridLables();
            PutRandomIcons();
        }

        private void InitializeIconsList()
        {
            icons = new List<string>()
            { "e", "e", "d", "d", "k", "k", "b", "b",
              "v", "v", "!", "!", "N", "N", "$", "$"
            };
        }

        private void InitializeGrid()
        {
            this.Width = 600;
            this.Height = 600;
            Grid.BackColor = Color.LightSteelBlue;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
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
                        ForeColor = Color.LightSteelBlue,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Webdings", 72, FontStyle.Bold),
                    };
                    label.Click += new EventHandler(Label_Click);
                    Grid.Controls.Add(label, c, r);
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Black;
            if(labelOne == null)
            {
                labelOne = label;
                return;
            }
            else
            {
                labelTwo = label;
                if(labelTwo.Text == labelOne.Text)
                {
                    labelOne = null;
                    labelTwo = null;
                    return;
                }
                else
                {
                    labelOne.ForeColor = Color.LightSteelBlue;
                    labelTwo.ForeColor = Color.LightSteelBlue;
                    labelOne = null;
                    labelTwo = null;
                    return;
                }
            }
        }


        private void PutRandomIcons()
        {
            Label label;
            for(int i = 0; i < 16; i++)
            {
                int randomIndex = rand.Next(0, icons.Count);
                label = (Label)Grid.Controls[i];
                label.Text = icons[randomIndex];
                icons.RemoveAt(randomIndex);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R)
            {
                InitializeIconsList();
                PutRandomIcons();
            }
        }
    }
}
