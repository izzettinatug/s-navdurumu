using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_sınav_notları_hesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double s1, s2, prj;
            double ort;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            prj = Convert.ToInt32(textBox5.Text);
            ort = (s1 * 60 / 100 + s2 * 40 / 100 + prj * 50 / 100) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + "\n" + "Ortalama:" + ort);

        }
    }
}
