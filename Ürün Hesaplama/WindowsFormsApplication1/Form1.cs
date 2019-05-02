using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKdvOrani.Text == "1")
	        {
                double BirimFiyatı, KdvDahilBirimFiyati, Adet, Tutar, TaksitSayisi, TaksitTutarı;
                BirimFiyatı = double.Parse(txtBirimFiyati.Text);
                Adet = double.Parse(txtAdet.Text);
                TaksitSayisi = double.Parse(txtTaksitSayisi.Text);
                KdvDahilBirimFiyati = BirimFiyatı + (BirimFiyatı * 0.01);
                txtKdvDahilBirimFiyatı.Text = KdvDahilBirimFiyati.ToString();
                Tutar = KdvDahilBirimFiyati * Adet;
                txtTutar.Text = Tutar.ToString();
                TaksitTutarı = Tutar / TaksitSayisi;
                txtTaksitTutari.Text = TaksitTutarı.ToString();
	        }

            if (cmbKdvOrani.Text == "5")
            {
                double BirimFiyatı, KdvDahilBirimFiyati, Adet, Tutar, TaksitSayisi, TaksitTutarı;
                BirimFiyatı = double.Parse(txtBirimFiyati.Text);
                Adet = double.Parse(txtAdet.Text);
                TaksitSayisi = double.Parse(txtTaksitSayisi.Text);
                KdvDahilBirimFiyati = BirimFiyatı + (BirimFiyatı * 0.05);
                txtKdvDahilBirimFiyatı.Text = KdvDahilBirimFiyati.ToString();
                Tutar = KdvDahilBirimFiyati * Adet;
                txtTutar.Text = Tutar.ToString();
                TaksitTutarı = Tutar / TaksitSayisi;
                txtTaksitTutari.Text = TaksitTutarı.ToString();
            }

            if (cmbKdvOrani.Text == "8")
            {
                double BirimFiyatı, KdvDahilBirimFiyati, Adet, Tutar, TaksitSayisi, TaksitTutarı;
                BirimFiyatı = double.Parse(txtBirimFiyati.Text);
                Adet = double.Parse(txtAdet.Text);
                TaksitSayisi = double.Parse(txtTaksitSayisi.Text);
                KdvDahilBirimFiyati = BirimFiyatı + (BirimFiyatı * 0.08);
                txtKdvDahilBirimFiyatı.Text = KdvDahilBirimFiyati.ToString();
                Tutar = KdvDahilBirimFiyati * Adet;
                txtTutar.Text = Tutar.ToString();
                TaksitTutarı = Tutar / TaksitSayisi;
                txtTaksitTutari.Text = TaksitTutarı.ToString();
            }

            if (cmbKdvOrani.Text == "10")
            {
                double BirimFiyatı, KdvDahilBirimFiyati, Adet, Tutar, TaksitSayisi, TaksitTutarı;
                BirimFiyatı = double.Parse(txtBirimFiyati.Text);
                Adet = double.Parse(txtAdet.Text);
                TaksitSayisi = double.Parse(txtTaksitSayisi.Text);
                KdvDahilBirimFiyati = BirimFiyatı + (BirimFiyatı * 0.10);
                txtKdvDahilBirimFiyatı.Text = KdvDahilBirimFiyati.ToString();
                Tutar = KdvDahilBirimFiyati * Adet;
                txtTutar.Text = Tutar.ToString();
                TaksitTutarı = Tutar / TaksitSayisi;
                txtTaksitTutari.Text = TaksitTutarı.ToString();
            }

            if (cmbKdvOrani.Text == "18")
            {
                double BirimFiyatı, KdvDahilBirimFiyati, Adet, Tutar, TaksitSayisi, TaksitTutarı;
                BirimFiyatı = double.Parse(txtBirimFiyati.Text);
                Adet = double.Parse(txtAdet.Text);
                TaksitSayisi = double.Parse(txtTaksitSayisi.Text);
                KdvDahilBirimFiyati = BirimFiyatı + (BirimFiyatı * 0.18);
                txtKdvDahilBirimFiyatı.Text = KdvDahilBirimFiyati.ToString();
                Tutar = KdvDahilBirimFiyati * Adet;
                txtTutar.Text = Tutar.ToString();
                TaksitTutarı = Tutar / TaksitSayisi;
                txtTaksitTutari.Text = TaksitTutarı.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKdvDahilBirimFiyatı.ReadOnly = true;
            txtTutar.ReadOnly = true;
            txtTaksitTutari.ReadOnly = true;
        }
    }
}
