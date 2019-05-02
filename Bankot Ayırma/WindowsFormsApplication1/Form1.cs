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
            int Adet, Para;
            Para = int.Parse(txtPara.Text);

            lblPara.Text = "";

            if (Para >= 200)
            {
                Adet = Para / 200;
                Para = Para % 200;
                lblPara.Text += Adet.ToString() + " Adet 200 TL \n";
            }

            if (Para >= 100)
            {
                Adet = Para / 100;
                Para = Para % 100;
                lblPara.Text += Adet.ToString() + " Adet 100 TL \n";
            }

            if (Para >= 50)
            {
                Adet = Para / 50;
                Para = Para % 50;
                lblPara.Text += Adet.ToString() + " Adet 50 TL \n";
            }

            if (Para >= 20)
            {
                Adet = Para / 20;
                Para = Para % 20;
                lblPara.Text += Adet.ToString() + " Adet 20 TL \n";
            }

            if (Para >= 10)
            {
                Adet = Para / 10;
                Para = Para % 10;
                lblPara.Text += Adet.ToString() + " Adet 10 TL \n";
            }

            if (Para >= 5)
            {
                Adet = Para / 5;
                Para = Para % 5;
                lblPara.Text += Adet.ToString() + " Adet 5 TL \n";
            }

            if (Para >= 1)
            {
                Adet = Para / 1;
                Para = Para % 1;
                lblPara.Text += Adet.ToString() + " Adet 1 TL \n";
            }


        }
    }
}
