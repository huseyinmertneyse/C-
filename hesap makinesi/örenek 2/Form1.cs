using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örenek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Topla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 + sayi2;
            txtSayi3.Text = sonuc.ToString();
        }

        private void Cıkarma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 - sayi2;
            txtSayi3.Text = sonuc.ToString();
        }

        private void Carpma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 * sayi2;
            txtSayi3.Text = sonuc.ToString();
        }

        private void Bolme_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc ;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 / sayi2;
            txtSayi3.Text = sonuc.ToString();
            
        }

        private void Kalan_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            sonuc = sayi1 % sayi2;
            txtSayi3.Text = sonuc.ToString();
        }
       
    }
}
