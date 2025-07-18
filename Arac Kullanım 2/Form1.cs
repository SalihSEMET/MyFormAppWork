using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanım_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Adınız:" + textBox1.Text);
            MessageBox.Show("Soyadınız:" + textBox5.Text);
            MessageBox.Show("Mesleğiniz::" + textBox4.Text);
            MessageBox.Show("Yaşadığınız Şehir:" + textBox3.Text);
        }
    }
}
