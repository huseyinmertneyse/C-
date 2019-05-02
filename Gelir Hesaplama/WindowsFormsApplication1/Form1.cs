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

            if (radioEvli.Checked == true)
            {

                if (txtCocukSayisi.Text == "0")
                {
                    
                    double BrutMaas, MesaiUcreti, BrutEkOdeme, MesaiSaati,NetEkOdeme, NetMaas, ToplamOdeme;
                    BrutMaas = double.Parse(txtBrutMaas.Text);
                    MesaiSaati = double.Parse(txtMesaiSaati.Text);
                    MesaiUcreti = (BrutMaas / 160) * 1.35;
                    BrutEkOdeme = MesaiUcreti * MesaiSaati;
 
                    

                    if (cmbVergiDilimi.Text == "%15")
                    {
                        
                    NetEkOdeme = BrutEkOdeme * 0.85;
                    txtNetEk.Text = NetEkOdeme.ToString();
                    txtBrutEk.Text = BrutEkOdeme.ToString();
                    NetMaas = BrutMaas - (BrutMaas * 0.15);
                    txtNetMaas.Text = NetMaas.ToString();
                    ToplamOdeme = NetEkOdeme + NetMaas;
                    txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%20")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.80;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.20);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%27")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.73;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.27);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%35")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.65;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.35);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }
                }

                if (txtCocukSayisi.Text == "1")
                {
                    double BrutMaas, MesaiUcreti, BrutEkOdeme, MesaiSaati, NetEkOdeme, NetMaas, ToplamOdeme;
                    BrutMaas = double.Parse(txtBrutMaas.Text);
                    MesaiSaati = double.Parse(txtMesaiSaati.Text);
                    MesaiUcreti = (BrutMaas / 160) * 1.40;
                    BrutEkOdeme = MesaiUcreti * MesaiSaati;
                    txtBrutEk.Text = BrutEkOdeme.ToString();



                    if (cmbVergiDilimi.Text == "%15")
                    {

                        NetEkOdeme = BrutEkOdeme * 0.85;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.15);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%20")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.80;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.20);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%27")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.73;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.27);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%35")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.65;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.35);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }
                }

                if (txtCocukSayisi.Text == "2")
                {
                    double BrutMaas, MesaiUcreti, BrutEkOdeme, MesaiSaati, NetEkOdeme, NetMaas, ToplamOdeme;
                    BrutMaas = double.Parse(txtBrutMaas.Text);
                    MesaiSaati = double.Parse(txtMesaiSaati.Text);
                    MesaiUcreti = (BrutMaas / 160) * 1.45;
                    BrutEkOdeme = MesaiUcreti * MesaiSaati;
                    txtBrutEk.Text = BrutEkOdeme.ToString();


                    if (cmbVergiDilimi.Text == "%15")
                    {

                        NetEkOdeme = BrutEkOdeme * 0.85;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.15);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%20")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.80;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.20);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%27")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.73;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.27);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%35")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.65;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.35);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }
                }

                if (double.Parse(txtCocukSayisi.Text) >= 3 )
                {
                    txtCocukSayisi.Enabled = false;
                    double BrutMaas, MesaiUcreti, BrutEkOdeme, MesaiSaati, NetEkOdeme, NetMaas, ToplamOdeme;
                    BrutMaas = double.Parse(txtBrutMaas.Text);
                    MesaiSaati = double.Parse(txtMesaiSaati.Text);
                    MesaiUcreti = (BrutMaas / 160) * 1.50;
                    BrutEkOdeme = MesaiUcreti * MesaiSaati;
                    txtBrutEk.Text = BrutEkOdeme.ToString();


                    if (cmbVergiDilimi.Text == "%15")
                    {

                        NetEkOdeme = BrutEkOdeme * 0.85;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.15);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%20")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.80;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.20);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%27")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.73;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.27);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%35")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.65;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.35);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }   
                }

                


            }

            if (radioBekar.Checked == true)
            {
                double BrutMaas, MesaiUcreti, BrutEkOdeme, MesaiSaati, NetEkOdeme, NetMaas, ToplamOdeme;
                    BrutMaas = double.Parse(txtBrutMaas.Text);
                    MesaiSaati = double.Parse(txtMesaiSaati.Text);
                    MesaiUcreti = (BrutMaas / 160) * 1.25;
                    BrutEkOdeme = MesaiUcreti * MesaiSaati;
                    txtBrutEk.Text = BrutEkOdeme.ToString();

                    if (cmbVergiDilimi.Text == "%15")
                    {

                        NetEkOdeme = BrutEkOdeme * 0.85;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.15);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%20")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.80;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.20);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%27")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.73;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.27);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }

                    if (cmbVergiDilimi.Text == "%35")
                    {
                        NetEkOdeme = BrutEkOdeme * 0.65;
                        txtNetEk.Text = NetEkOdeme.ToString();
                        txtBrutEk.Text = BrutEkOdeme.ToString();
                        NetMaas = BrutMaas - (BrutMaas * 0.35);
                        txtNetMaas.Text = NetMaas.ToString();
                        ToplamOdeme = NetEkOdeme + NetMaas;
                        txtToplamOdeme.Text = ToplamOdeme.ToString();
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCocukSayisi.Enabled = false;
            txtBrutEk.ReadOnly = true;
            txtNetEk.ReadOnly = true;
            txtNetMaas.ReadOnly = true;
            txtToplamOdeme.ReadOnly = true;
        }

        private void radioEvli_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayisi.Enabled = true;
        }

        private void cmbVergiDilimi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioBekar_CheckedChanged(object sender, EventArgs e)
        {
            txtCocukSayisi.Enabled = false;
        }
    }
}
