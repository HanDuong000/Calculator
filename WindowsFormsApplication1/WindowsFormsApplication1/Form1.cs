﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKQ.Text = c.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKQ.Text = c.ToString();
        }
    }
}
