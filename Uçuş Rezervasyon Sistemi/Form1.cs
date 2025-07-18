using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçuş_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Edildi");
            listBox1.Items.Add("Nereden:" + comboBox1.Text + "=>" + "Nereye" +comboBox2.Text);
            listBox1.Items.Add("Tarih:" + dateTimePicker1.Text + " " + "Saat:" + maskedTextBox1.Text);
            listBox2.Items.Add("Adınız:" + textBox1.Text);
            listBox2.Items.Add("Soyadınız:" + textBox2.Text);
            listBox2.Items.Add("Tc No:" + maskedTextBox2.Text);
            listBox2.Items.Add("Tel No:" + maskedTextBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }
    }
}
