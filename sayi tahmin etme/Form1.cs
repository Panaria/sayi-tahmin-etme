using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmin_etme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            int sayac = 0;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            sayi3 = int.Parse(textBox3.Text);

            Random rnd = new Random();
            label1.Text = rnd.Next(1, 23).ToString();
            label2.Text = rnd.Next(1, 23).ToString();
            label3.Text = rnd.Next(1, 23).ToString();

            if (sayi1 == int.Parse(label1.Text) || sayi1 == int.Parse(label2.Text) || sayi1 == int.Parse(label3.Text))
            {
                sayac++;
            }
            if (sayi2 == int.Parse(label1.Text) || sayi2 == int.Parse(label2.Text) || sayi2 == int.Parse(label3.Text))
            {
                sayac++;
            }
            if (sayi3 == int.Parse(label1.Text) || sayi3 == int.Parse(label2.Text) || sayi3 == int.Parse(label3.Text))
            {
                sayac++;
            }

            MessageBox.Show(sayac + " Sayı Tahmin Ettiniz");
            
        }
    }
}
