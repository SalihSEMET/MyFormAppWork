﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100;i+=5)
            {
                listBox1.Items.Add("Merhaba Ankara");
            }
            for (int i = 1; i < 11; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
