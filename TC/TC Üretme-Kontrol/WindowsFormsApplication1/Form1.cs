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
            
        bas:
            
            int hane; 
            string tcTum = "", tc = "";
            Random uret = new Random();
            for (int i = 0; i < 11; i++)
            {
                hane = uret.Next(0, 10);
                tcTum += hane.ToString();
            }
            tc = tcTum;

            int tc1 = Convert.ToInt32(tc[0].ToString());
            int tc2 = Convert.ToInt32(tc[1].ToString());
            int tc3 = Convert.ToInt32(tc[2].ToString());
            int tc4 = Convert.ToInt32(tc[3].ToString());
            int tc5 = Convert.ToInt32(tc[4].ToString());
            int tc6 = Convert.ToInt32(tc[5].ToString());
            int tc7 = Convert.ToInt32(tc[6].ToString());
            int tc8 = Convert.ToInt32(tc[7].ToString());
            int tc9 = Convert.ToInt32(tc[8].ToString());
            int tc10 = Convert.ToInt32(tc[9].ToString());
            int tc11 = Convert.ToInt32(tc[10].ToString());

            int onhane = (((tc1 + tc3 + tc5 + tc7 + tc9) * 7) - (tc2 + tc4 + tc6 + tc8)) % 10;
            int onbirhane = (tc1 + tc2 + tc3 + tc4 + tc5 + tc6 + tc7 + tc8 + tc9 + tc10) % 10;

            if ((tc1 != 0) && (onhane == tc10) && (onbirhane == tc11))
            {
               txtUret.Text = tc;

            }
            else
            {
                goto bas;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc="";
            tc = txtKontrol.Text;

            int tc1 = Convert.ToInt32(tc[0].ToString());
            int tc2 = Convert.ToInt32(tc[1].ToString());
            int tc3 = Convert.ToInt32(tc[2].ToString());
            int tc4 = Convert.ToInt32(tc[3].ToString());
            int tc5 = Convert.ToInt32(tc[4].ToString());
            int tc6 = Convert.ToInt32(tc[5].ToString());
            int tc7 = Convert.ToInt32(tc[6].ToString());
            int tc8 = Convert.ToInt32(tc[7].ToString());
            int tc9 = Convert.ToInt32(tc[8].ToString());
            int tc10 = Convert.ToInt32(tc[9].ToString());
            int tc11 = Convert.ToInt32(tc[10].ToString());

            int onhane = (((tc1 + tc3 + tc5 + tc7 + tc9) * 7) - (tc2 + tc4 + tc6 + tc8)) % 10;
            int onbirhane = (tc1 + tc2 + tc3 + tc4 + tc5 + tc6 + tc7 + tc8 + tc9 + tc10) % 10;

            if ((tc1 != 0) && (onhane == tc10) && (onbirhane == tc11))
            {

                MessageBox.Show("Girilen TC Kimlik Numarası Doğrudur.");

            }
            else
            {
                MessageBox.Show("Girilen TC Geçersizdir!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUret.ReadOnly=true;
        }
    }
}
