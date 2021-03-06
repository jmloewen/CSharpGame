﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MessinAround
{
    public partial class frmLoad : Form
    {
        const int boxsize = 30;
        public frmLoad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = boxsize * 25 + 17;
            this.Height = boxsize * 21 + 10;
        }

        private void frmLoad_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.CornflowerBlue, 0, 0, this.Width, this.Height);

           
            

            //want 40 squares across, 30 down.  20px across, 15px tall.
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    e.Graphics.DrawRectangle(Pens.Black, j * boxsize, i * boxsize, boxsize, boxsize);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Mover tmp = new Mover();
                e.Graphics.FillRectangle(Brushes.SandyBrown, tmp.getX(), tmp.getY(), tmp.getWidth(), tmp.getHeight());

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void frmLoad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
