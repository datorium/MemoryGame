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
        List<string> icons = new List<string>
        {
            "e", "e", "b", "b", "d", "d", "k", "k",
            "v", "v", "!", "!", "$", "$", "N", "N"
        };
        Random rand = new Random();
        Label labelOne = null, labelTwo = null;
        Timer mainTimer = null;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            FillTheGrid();
            GenerateIcons();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            mainTimer = new Timer();
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            labelOne.ForeColor = Color.LightSteelBlue;
            labelTwo.ForeColor = Color.LightSteelBlue;
            labelOne = null;
            labelTwo = null;
            mainTimer.Stop();
        }

        private void InitializeGrid()
        {
            this.Width = 600;
            this.Height = 600;
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
                        ForeColor = Color.LightSteelBlue,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Font = new Font("Webdings", 72)
                    };
                    label.Click += new EventHandler(Label_Click);

                    Grid.Controls.Add(label, c, r);
                }
            }            
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if(labelOne == null)
            {
                labelOne = label;
                label.ForeColor = Color.Black;
                return;
            }
            else
            {
                labelTwo = label;
                label.ForeColor = Color.Black;
                if (labelOne == labelTwo)
                {                    
                    return;
                }
                else
                {
                    mainTimer.Start();
                }
            }
            



            
        }

        private void GenerateIcons()
        {
            int randomIndex;
            Label label;

            for(int i = 0; i < 16; i++)
            {
                randomIndex = rand.Next(0, icons.Count);
                label = (Label)Grid.Controls[i];
                label.Text = icons[randomIndex];
                icons.RemoveAt(randomIndex);
            }
        }
    }
}
