﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; string surname = textBox2.Text;
            int exam1 = Convert.ToInt16(textBox3.Text); int exam2 = Convert.ToInt16(textBox4.Text); int project = Convert.ToInt16(textBox5.Text); double resoult = (exam1 + exam2 + project) / 3;
            listBox1.Items.Add("Adınız:"+name);
            listBox1.Items.Add("Soyadınız:"+surname);
            listBox1.Items.Add("Ortalamanız:"+resoult);
        }
    }
}
