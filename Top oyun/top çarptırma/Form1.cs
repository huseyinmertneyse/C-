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
        int yonx = 2, yony = 2,hiz=2,sure=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nesne.Left+40 <= 0)
            {
                yonx = 1;
            }
            if (nesne.Left >= this.Width - nesne.Width + 30)
            { 
                yonx = -1;
            }
            if (nesne.Top <= 0)
            {
                yony = 1;
            }
           // if (nesne.Top >= this.Height - nesne.Height - 30)
           // {
           //     yony = -1;
           // }

            if (nesne.Top >= tahta.Top - nesne.Height+40 && nesne.Left >= tahta.Left-49 && nesne.Left <= tahta.Left+244 && nesne.Top+50<=tahta.Top )
            {
                yony = -1;
                hiz += 1;
                if (hiz>=30)
                {
                    hiz = 30;
                }
                
            }
            else if (nesne.Top + 50 >= tahta.Top)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Kaçırdınız...\nRekorunuz " + sure + " Saniye");
                button1.Enabled = true;
                button2.Enabled = false;
                nesne.Left = 607;
                nesne.Top = 111;
            }
            nesne.Left += yonx * hiz;
            nesne.Top += yony * hiz;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tahta.Left = MousePosition.X-122 - this.Location.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure++;
            label2.Text = sure.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            hiz = 1;
            timer1.Enabled = true;
            timer2.Enabled = true;
            sure = 0;
            label2.Text="0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
    }
}
