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
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 100)
            {
                i++;
                progressBar1.Value = i;
                label1.Text = "% " + progressBar1.Value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
           
        }
    }
}
