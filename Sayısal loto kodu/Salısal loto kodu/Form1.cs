using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salısal_loto_kodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i=0,sayi;
        
        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
                    i = 0;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
           
            

           i++;
           if (i<=5)
           {
               sayi = r.Next(0, 49);
               lbluretilensayi.Text = sayi.ToString();
           }
           else
           {
               lblsayi.Text += sayi.ToString() + "-";
               timer1.Enabled = false; 
           }
           
           

















            /*lbluretilensayi.Text = sayi.ToString();
            if (sayac == 5)
            {
                lblsayi1.Text = sayi.ToString();
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
          if (sayac==10)
            {   
                lblsayi2.Text = sayi.ToString();
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
            if (sayac == 15)
            {
                lblsayi3.Text = sayi.ToString();
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
            if (sayac == 20)
            {
                lblsayi4.Text = sayi.ToString();
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
            if (sayac == 25)
            {
                lblsayi5.Text = sayi.ToString();
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
            if (sayac == 30)
            {
                lblsayi6.Text = sayi.ToString();
                timer1.Enabled = false;
            }*/
        }
    }
}
