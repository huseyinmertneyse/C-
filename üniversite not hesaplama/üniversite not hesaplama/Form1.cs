using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üniversite_not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSonuc.ReadOnly = true;
            txtDersnotu.ReadOnly = true;
            txtbutunleme.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbutunleme.Enabled==false)
            {
                   txtDersnotu.Text=(int.Parse(txtVize.Text)*0.4 + int.Parse(txtFinal.Text)*0.6).ToString();
                   if (int.Parse(txtDersnotu.Text) >= 50 && int.Parse(txtFinal.Text) >= 50)
                    {
                        txtSonuc.Text = "GEÇTİ"; 
                    }
                   else
                   {
                       txtSonuc.Text = "BÜTÜNLEMEYE KALDI";
                       txtFinal.Enabled = false;
                       txtbutunleme.Enabled = true;
                   }
                }
                else
                {
                    txtDersnotu.Text = (int.Parse(txtVize.Text) * 0.4 + int.Parse(txtbutunleme.Text) * 0.6).ToString();
                    if (int.Parse(txtDersnotu.Text) >= 50 && int.Parse(txtbutunleme.Text) >= 50)
                    {
                        txtSonuc.Text = "BÜTÜNLEME İLE GEÇTİ";
                    }
                    else
                    {
                        txtSonuc.Text = "KALDI";
                        
                    }
                }
            }
        }
    }

