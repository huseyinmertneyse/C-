using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika=0, saniye=0, salise=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Dakika.Enabled = true;
        }

        private void Dakika_Tick(object sender, EventArgs e)
        {
            salise++;
            label3.Text = salise.ToString();
            while (salise ==10)
            {
                salise = 0;
                saniye++;
                label2.Text = saniye.ToString();
            }
            
            
            while (saniye==60)
            {
                saniye = 0;
                dakika++;
                label1.Text = dakika.ToString();
                
            }
            if (dakika < 10 )
            {
                label1.Text = "0"+dakika.ToString();
            }
            if (saniye < 10)
            {
                label2.Text = "0" + saniye.ToString();
            }
            if (salise < 10)
            {
                label3.Text = "0" + salise.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dakika.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dakika.Enabled = true;
            dakika = 0;
            saniye = 0;
            salise = 0;
            
        }
    }
}
