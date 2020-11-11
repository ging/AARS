﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace plato_saga
{    
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            //borderRectangle.Inflate(-2, -2);
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
                Border3DStyle.Raised);
        }
    }
}
