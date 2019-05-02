using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top_çarptırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yonx = 1, yony = 1,hiz=1,puan=0,sure=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nesne.Left <= 0)
            {
                yonx = 1;
            }
            if (nesne.Left >= this.Width - nesne.Width - 10)
            { 
                yonx = -1;
            }
            if (nesne.Top <= 0)
            {
                yony = 1;
            }
           //// if (nesne.Top >= this.Height - nesne.Height - 30)
           // {
           //     yony = -1;
           // }

            if (nesne.Top >= tahta.Top - nesne.Height)
            {
                yony = -1;
            }
            
           // if (nesne.Left >= tahta.Left - nesne.Width)
           // {
            //    
            //}
            
            
            nesne.Left += yonx * hiz;
            nesne.Top += yony * hiz;
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hiz = hScrollBar1.Value;
            label1.Text = "Hız : "+hScrollBar1.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            nesne.Width = vScrollBar1.Value;
            nesne.Height = vScrollBar1.Value;
            
        }

        private void nesne_Click(object sender, EventArgs e)
        {

            puan+=hiz;
            label2.Text = (puan).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure==60)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Süre Doldu");
            }
            label3.Text = sure.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tahta.Left = MousePosition.X - this.Location.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
