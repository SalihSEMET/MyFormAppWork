﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 18;
            do
            {
                listBox1.Items.Add("Merhaba Samsun");
                i++;
                button1.Enabled = false;
            }
            while (i <= 10);
            {

            }
            
        }
    }
}
