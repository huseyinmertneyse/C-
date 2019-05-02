using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7nin_katına_kadar_üret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int enaz = 100, encok = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int uretilensayi = 0, sayac = 0;
            listBox1.Items.Clear();
            Random uret = new Random();
            do
            {
                sayac++;
                uretilensayi = uret.Next(1,100);
                listBox1.Items.Add(uretilensayi.ToString());
            } while (uretilensayi % 7 != 0);
            lbladet.Text = sayac.ToString();
            if (encok < sayac)
            {
                encok = sayac;
            }
            if (enaz > sayac)
            {
                enaz = sayac;    
            }
            lblencok.Text = encok.ToString();
            lblenaz.Text = enaz.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
