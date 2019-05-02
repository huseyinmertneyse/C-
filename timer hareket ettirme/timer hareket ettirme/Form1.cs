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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            denizanası1.Enabled = true;
            denizanası2.Enabled = true;
            denizanası3.Enabled = true;
           
           
            
            
        }

        private void denizanası1_Tick(object sender, EventArgs e)
        {
            int hiz = uret.Next(5, 100);
            denizanası1.Interval = hiz;
            pictureBox1.Left++;
            if (pictureBox1.Left > this.Width - 100)
            {
                denizanası1.Enabled = false;
                MessageBox.Show("1.");
            }
        }

        private void denizanası2_Tick(object sender, EventArgs e)
        {
            
            int hiz2 = uret.Next(5, 100);
            denizanası2.Interval = hiz2;
            pictureBox2.Left++;
            if (pictureBox2.Left > this.Width - 100)
            {
                denizanası2.Enabled = false;
                MessageBox.Show("2.");
            }
        }

        private void denizanası3_Tick(object sender, EventArgs e)
        {
            int hiz3 = uret.Next(5, 100);
            denizanası3.Interval = hiz3;
            pictureBox3.Left++;
            if (pictureBox3.Left > this.Width - 100)
            {
                denizanası3.Enabled = false;
                MessageBox.Show("3.");
            }
        }
    }
}
