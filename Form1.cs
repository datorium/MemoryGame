﻿using System;
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
        List<string> icons = new List<string>()
        { "e", "e", "d", "d", "k", "k", "b", "b",
          "N", "N", "!", "!", "&", "&", "$", "$"        
        };

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            AddGridLables();
            PutRandomIcons();
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
                        Font = new Font("Webdings", 72, FontStyle.Bold)                        
                    };
                    Grid.Controls.Add(label, c, r);
                }
            }
        }

        private void PutRandomIcons()
        {
            Label label;
            for(int i = 0; i < 16; i++)
            {
                int randomIndex = rand.Next(0, 16);
                label = (Label)Grid.Controls[i];
                label.Text = icons[randomIndex];
            }
        }

    }
}
