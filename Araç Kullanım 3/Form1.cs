using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kullanım_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Adınız:" + textBox1.Text);
            listBox1.Items.Add("Soyadınız:" + textBox2.Text);
            listBox1.Items.Add("Tel No nuz:" + maskedTextBox1.Text);
            listBox1.Items.Add("Dogum Tarihiniz:" + dateTimePicker1.Text);
            listBox1.Items.Add("Yaşadınız Şehir:" + maskedTextBox4.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
