using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        string [] isimler = new string[100];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(isimler,textBox1.Text)==-1)
            {
                isimler[sayac]=textBox1.Text;
                sayac++;
                label2.ForeColor=Color.Green;
                label2.Text="İsim diziye eklendi...";
            }
            else
	        {
                label2.ForeColor=Color.Red;
                label2.Text="İsim dizide bulunuyor.EKLENEMEDİ";
	        }
            textBox1.Text="";
         }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayac; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }

      
    }
}
