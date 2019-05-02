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
            double index = 1;
            double kilo = double.Parse(txtKilo.Text);
            double boy = double.Parse(txtBoy.Text);
            double altsinir, ustsinir;

            index = (kilo / (boy * boy));
            lblSonuc.Text = index.ToString();

          

            if (index <= 18.5)
            {
                lblYazdır.Text = "Zayıf..";
            }
            if (index<=24.9 && index>= 18.5)
	        {
                lblYazdır.Text = "Normal..";
	        }
            if (index <= 29.9 && index >= 25)
            {
                lblYazdır.Text = "Fazla Kilolu..";
            }
            if (index <= 39.9 && index >= 30)
            {
                lblYazdır.Text = "Obez..";
            }
            if (index >= 40)
            {
                lblYazdır.Text = "Aşırı Obez..";
            }

            altsinir = 18.5 * boy * boy;
            ustsinir = 24.9 * boy * boy;

            if (index < 18.5)
            {
                lblSinir.Text = (altsinir - kilo).ToString() + (ustsinir - kilo).ToString() + "  kilo almalısınız";
            }
            if (index > 25)
            {
                lblSinir.Text = (kilo - altsinir).ToString() + (kilo - ustsinir).ToString() + "  arasında kilo vermelisiniz";
            }    
            
        }      
    }
}
