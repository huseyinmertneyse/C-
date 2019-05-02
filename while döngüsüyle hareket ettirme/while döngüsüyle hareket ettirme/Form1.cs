using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_döngüsüyle_hareket_ettirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            int hiz; 
            
            do
            {
                hiz = r.Next(1, 40000);
                pictureBox1.Left++;
                double i = 0;
                do
                {
                    i+=0.01;
                } while (i <= hiz);

            } while (pictureBox1.Left <= this.Width - 90);
             do
            {
                hiz = r.Next(1, 40000);
                pictureBox2.Left++;
                double i = 0;
                do
                {
                    i+=0.01;
                } while (i <= hiz);

            } while (pictureBox2.Left <= this.Width- 90);
             
            do
            {
                hiz = r.Next(1, 40000);
                pictureBox3.Left++;
                double i = 0;
                do
                {
                    i+=0.01;
                } while (i <= hiz);

            } while (pictureBox3.Left <= this.Width - 90);
            
        }
    }
}
