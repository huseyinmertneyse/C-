using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burç_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAy.Text == "Ay" || cmbGun.Text == "Gün")
            {

            }
            else
            {
                int gun = int.Parse(cmbGun.Text);
                string ay = cmbAy.Text;



                if (ay == "Ocak")
                {

                    if (gun <= 21)
                    {
                        lblBurc.Text = "Oğlak";
                    }
                    else
                    {
                        lblBurc.Text = "Kova";
                    }

                }
                if (ay == "Şubat")
                {
                    if (gun <= 19)
                    {
                        lblBurc.Text = "Kova";
                    }
                    else
                    {
                        lblBurc.Text = "Balık";
                    }
                }
                if (ay == "Mart")
                {
                    if (gun >= 21)
                    {
                        lblBurc.Text = "Koç";
                    }
                    else
                    {
                        lblBurc.Text = "Balık";
                    }
                }
                if (ay == "Nisan")
                {
                    if (gun >= 21)
                    {
                        lblBurc.Text = "Boğa";
                    }
                    else
                    {
                        lblBurc.Text = "Koç";
                    }
                }
                if (ay == "Mayıs")
                {
                    if (gun >= 22)
                    {
                        lblBurc.Text = "İkizler";
                    }
                    else
                    {
                        lblBurc.Text = "Boğa";
                    }
                }
                if (ay == "Haziran")
                {
                    if (gun >= 23)
                    {
                        lblBurc.Text = "Yengeç";
                    }
                    else
                    {
                        lblBurc.Text = "İkizler";
                    }
                }
                if (ay == "Temmuz")
                {
                    if (gun >= 23)
                    {
                        lblBurc.Text = "Aslan";
                    }
                    else
                    {
                        lblBurc.Text = "Yengeç";
                    }
                }
                if (ay == "Ağustos")
                {
                    if (gun <= 22)
                    {
                        lblBurc.Text = "Aslan";
                    }
                    else
                    {
                        lblBurc.Text = "Başak";
                    }
                }
                if (ay == "Eylül")
                {
                    if (gun >= 23)
                    {
                        lblBurc.Text = "Terazi";
                    }
                    else
                    {
                        lblBurc.Text = "Başak";
                    }
                }
                if (ay == "Ekim")
                {
                    if (gun >= 23)
                    {
                        lblBurc.Text = "Akrep";
                    }
                    else
                    {
                        lblBurc.Text = "Terazi";
                    }
                }
                if (ay == "Kasım")
                {
                    if (gun >= 22)
                    {
                        lblBurc.Text = "Yay";
                    }
                    else
                    {
                        lblBurc.Text = "Akrep";
                    }
                }
                if (ay == "Aralık")
                {
                    if (gun <= 22)
                    {
                        lblBurc.Text = "Oğlak";
                    }
                    else
                    {
                        lblBurc.Text = "Yay";
                    }
                }


            }
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBurc.Text = "";
            cmbGun.Text = "Gün";
            cmbAy.Text = "Ay";
        }

        





        
    }
}
