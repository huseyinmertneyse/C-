using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_bulunca_dur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayiuret = new Random();
        int uretilensayi = 0, toplam = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            toplam = 0;
            listBox1.Items.Clear();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           uretilensayi=sayiuret.Next(11);
           listBox1.Items.Add(uretilensayi.ToString());
           if (uretilensayi==0)
           {
               timer1.Enabled = false;
           }
           label1.Text = (toplam += uretilensayi).ToString(); ;
        }
    }
}
