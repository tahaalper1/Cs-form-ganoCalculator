using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gano_Hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double vize, final, ortalama;
           
            

            vize = Convert.ToInt32(textBox9.Text);
            final = Convert.ToInt32(textBox10.Text);

            ortalama = vize * 0.4 + final * 0.6;

            label12.Text = textBox2.Text;
            label14.Text = textBox4.Text.ToString();
            label11.Text = textBox1.Text;
            label13.Text = ortalama.ToString();

            if (ortalama >= 50)
            {

                label15.Text = "GEÇTİ";
            }
            else
            {
                label15.Text = "KALDI";
            }

        }
    }
}
