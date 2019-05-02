using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denklem_Çözme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "";
            lblX1.Text = "";
            lblX2.Text = "";
            double X1, X2;
            int a,b,c,delta;
            a=int.Parse(txta.Text);
            b=int.Parse(txtb.Text);
            c=int.Parse(txtc.Text);
            delta = (b*b)-(4*a*c);
            if (delta<0)
            {
                lblDurum.Text = "Reel Kök Yoktur !";
                lblX1.Text = "";
                lblX2.Text = "";
            }
            if (delta==0)
            {
                lblDurum.Text = "2 Eşit Kök Vardır!";
                X1 = -b / (2 * a);
                lblX1.Text = X1.ToString();
                lblX2.Text = X1.ToString();
            }
            if (delta>0)
            {
                lblDurum.Text = "2 Farklı Kök Vardır!";
                X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                lblX1.Text = X1.ToString();
                lblX2.Text = X2.ToString();
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDurum.Text = "";
            lblX1.Text = "";
            lblX2.Text = "";
        }
    }
}
