using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = label1.Location.X;
            x=x-10;
            label1.Left = x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = label1.Location.X;
            x=x+10;
            label1.Left = x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = label1.Location.Y;
            x=x-10;
            label1.Top = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = label1.Location.Y;
            x=x+10;
            label1.Top = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
