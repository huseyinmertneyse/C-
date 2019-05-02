using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "1.Onur Recep Kıvrak", "2.Gökhan Gönül", "3.Semih Kaya", "4.Bekir İrtegün", "5.Alper Potuk", "6.Nuri Şahin", "7.Hasan Ali Kaldırım", "8.Selçuk İnan", "9.Arda Turan", "10.Umut Bulut", "11.Burak Yılmaz" };

        


        
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayac = 0;
        }

int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = sayac + 1 + ".jpg";
            textBox1.Text = isimler[sayac];
            sayac++;
            if (sayac == 11)
            {
                sayac = 0;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int rasgele = 0;
            timer1.Enabled = false;
            Random r = new Random();
            rasgele = r.Next(0,11);
            pictureBox1.ImageLocation = rasgele + 1 + ".jpg";
           textBox1.Text = isimler[rasgele];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

     
        
    }
}
