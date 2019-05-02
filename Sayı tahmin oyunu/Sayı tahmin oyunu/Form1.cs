using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent(); 
        }

        int sayac = 1; 
        int uretilensayi = 0 ;
        private void Form1_Load(object sender, EventArgs e)
        {  
        Random uret = new Random();
        uretilensayi = uret.Next(0, 100);
        lblTahmin.Text = "";
        lblSayac.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSayac.Text = (sayac++).ToString()+". denemeniz...";
            if (int.Parse(txtTahmin.Text)<uretilensayi)
            {
                lblTahmin.Text = "Yukarı"; 
            }
            else if (int.Parse(txtTahmin.Text) > uretilensayi)
            {
                lblTahmin.Text = "Aşağı";
            }
            else
            {
                lblTahmin.Text = " Tebrikler\n BİLDİNİZ";
            }
            txtEski.Text = txtTahmin.Text;
            txtTahmin.Text = "";
            
        }

    }
}
