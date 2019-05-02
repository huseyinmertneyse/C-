using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_hareket_ettirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random uret = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
        }
        int hiz = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            denizanası1.Enabled = true;
            denizanası2.Enabled = true;
            denizanası3.Enabled = true;
            denizanası4.Enabled = true;
            denizanası5.Enabled = true;
            denizanası6.Enabled = true;
            
            
            
            
            
        }

        private void denizanası1_Tick(object sender, EventArgs e)
        {
            hiz = uret.Next(1,35);
            denizanası1.Interval = hiz;
            pictureBox1.Left++;
            if (pictureBox1.Left > this.Width - 100)
            {
                denizanası1.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası1.Enabled == false)
            {
                denizanası2.Enabled = false;
                denizanası3.Enabled = false;
                denizanası4.Enabled = false;
                denizanası5.Enabled = false;
                denizanası6.Enabled = false;
                MessageBox.Show("1.");
            }
        }

        private void denizanası2_Tick(object sender, EventArgs e)
        {
            
            hiz = uret.Next(1, 35);
            denizanası2.Interval = hiz;
            pictureBox2.Left++;
            if (pictureBox2.Left > this.Width - 100)
            {
                denizanası2.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası2.Enabled == false)
            {
                denizanası1.Enabled = false;
                denizanası3.Enabled = false;
                denizanası4.Enabled = false;
                denizanası5.Enabled = false;
                denizanası6.Enabled = false;
                MessageBox.Show("2.");
            }
        }

        private void denizanası3_Tick(object sender, EventArgs e)
        {
            hiz = uret.Next(1, 35);
            denizanası3.Interval = hiz;
            pictureBox3.Left++;
            if (pictureBox3.Left > this.Width - 100)
            {
                denizanası3.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası3.Enabled == false)
            {
                denizanası2.Enabled = false;
                denizanası1.Enabled = false;
                denizanası4.Enabled = false;
                denizanası5.Enabled = false;
                denizanası6.Enabled = false;
                MessageBox.Show("3.");
            }
        }

        private void denizanası4_Tick(object sender, EventArgs e)
        {
            hiz = uret.Next(1, 35);
            denizanası4.Interval = hiz;
            pictureBox4.Left++;
            if (pictureBox4.Left > this.Width - 100)
            {
                denizanası4.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası4.Enabled == false)
            {
                denizanası2.Enabled = false;
                denizanası3.Enabled = false;
                denizanası1.Enabled = false;
                denizanası5.Enabled = false;
                denizanası6.Enabled = false;
                MessageBox.Show("4.");
            }
        }

        private void denizanası5_Tick(object sender, EventArgs e)
        {
            hiz = uret.Next(1, 35);
            denizanası5.Interval = hiz;
            pictureBox5.Left++;
            if (pictureBox5.Left > this.Width - 100)
            {
                denizanası5.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası5.Enabled == false)
            {
                denizanası2.Enabled = false;
                denizanası3.Enabled = false;
                denizanası4.Enabled = false;
                denizanası1.Enabled = false;
                denizanası6.Enabled = false;
                MessageBox.Show("5.");
            }
        }

        private void denizanası6_Tick(object sender, EventArgs e)
        {
            hiz = uret.Next(1, 35);
            denizanası6.Interval = hiz;
            pictureBox6.Left++;
            if (pictureBox6.Left > this.Width - 100)
            {
                denizanası6.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            if (denizanası6.Enabled == false)
            {
                denizanası2.Enabled = false;
                denizanası3.Enabled = false;
                denizanası4.Enabled = false;
                denizanası5.Enabled = false;
                denizanası1.Enabled = false;
                MessageBox.Show("6.");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            hiz = 0;
            denizanası1.Enabled = false;
            denizanası2.Enabled = false;
            denizanası3.Enabled = false;
            denizanası4.Enabled = false;
            denizanası5.Enabled = false;
            denizanası6.Enabled = false;
            
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            pictureBox5.Left = 0;
            pictureBox6.Left = 0;
            
            button1.Enabled = true;
            button2.Enabled = false;


        }
    }
}
