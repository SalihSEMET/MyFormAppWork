using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }
        int sayac = 0;
        int total = 0;
        int shownumber = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            shownumber = total + sayac;
            label1.Text = shownumber.ToString();

            if (sayac == 10)
            {
                this.BackColor = Color.OrangeRed;
            }
            if (sayac == 15)
            {
                this.BackColor = Color.Orange;
            }
            if (sayac == 20)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac == 25)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Cyan;
            }
            if (sayac == 35)
            {
                this.BackColor = Color.Aqua;
            }
            if (sayac == 40)
            {
                this.BackColor = Color.Blue;
                    
            }
            if (sayac == 45)
            {
                this.BackColor = Color.DarkBlue;
            }
            if (sayac == 50)
            {
                this.BackColor = Color.Purple;
            }
            if (sayac == 55)
            {
                this.BackColor = Color.Pink;
            }
            if (sayac == 60)
            {
                this.BackColor = Color.Red;
                total += sayac;
                sayac = 0;
            }
            if(total == 360)
            {
                timer1.Stop();
            }
        }
    }
}
