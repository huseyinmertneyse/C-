using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 1;
            sayi = int.Parse(txtSayi.Text);
            string yildiz="";

            for (int i = 1; i <= sayi; i++)
            {
                yildiz += " * ";
                lblSonuc.Text = yildiz;
            }
            
        }
    }
}
