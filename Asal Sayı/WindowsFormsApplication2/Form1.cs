using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi.Text);
            bool durum = false;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    durum=true;
                }
            }
            if (durum == true)
            {
                lblSonuc.Text = "Asal Sayı Değildir";
            }
            else if(durum == false)
            {
                lblSonuc.Text = "Asal Sayıdır";
            }
        }
    }
}
