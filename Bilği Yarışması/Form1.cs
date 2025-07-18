using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilği_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _questionno = 0, _correct = 0, _false =0;

        private void btnA_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnA.Text; 
            if(label4.Text == label5.Text)
            {
                _correct++; lblCorrectNo.Text = _correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                _false++;
                lblFalseNo.Text = _false.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                _correct++; lblCorrectNo.Text = _correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                _false++;
                lblFalseNo.Text = _false.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                _correct++; lblCorrectNo.Text = _correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                _false++;
                lblFalseNo.Text = _false.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                _correct++; lblCorrectNo.Text = _correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                _false++;
                lblFalseNo.Text = _false.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            _questionno++; lblquestionNo.Text = _questionno.ToString();

            if(_questionno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Ne Zaman İlan Edilmiştir";
                btnA.Text = "1920"; btnB.Text = "1921"; btnC.Text = "1922"; btnD.Text = "1923";
                label4.Text = "1923";

            }
            if(_questionno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege Bölgesinde Bulunmaz";
                btnA.Text = "İzmir"; btnB.Text = "Balıkesir"; btnC.Text = "Aydın"; btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if(_questionno == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazarımıza Aittir";
                btnA.Text = "Sait Faik"; btnB.Text = "Cemal Süreyya"; btnC.Text = "Atilla İlhan"; btnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btnNext.Text = "Sonuçlar";
            }
            if(_questionno == 4)
            {
                lblquestionNo.Text = "3";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Dogru: " + _correct + "\n" + "Yanlış" + _false );
            }
        }
    }
}
