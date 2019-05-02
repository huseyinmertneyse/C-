using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalamayı_5lik_not_sistemin_dönüştürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOrtalama.Text = ((int.Parse(txt1not.Text) + int.Parse(txt2not.Text) + int.Parse(txtSozlu.Text)) / 3).ToString();
            if (int.Parse(txtOrtalama.Text)<25 && int.Parse(txtOrtalama.Text)>=0)
            {
                txtNotu.Text = "0";
            }
            else if (int.Parse(txtOrtalama.Text) < 50 && int.Parse(txtOrtalama.Text) >= 25)
            {
                txtNotu.Text = "1";
            }
            else if (int.Parse(txtOrtalama.Text) < 60 && int.Parse(txtOrtalama.Text) >= 50)
            {
                txtNotu.Text = "2";
            }
            else if (int.Parse(txtOrtalama.Text) < 70 && int.Parse(txtOrtalama.Text) >= 60)
            {
                txtNotu.Text = "3";
            }
            else if (int.Parse(txtOrtalama.Text) < 85 && int.Parse(txtOrtalama.Text) >= 70)
            {
                txtNotu.Text = "4";
            }
            else if (int.Parse(txtOrtalama.Text) <=100  && int.Parse(txtOrtalama.Text) >= 85)
            {
                txtNotu.Text = "5";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOrtalama.ReadOnly = true;
            txtNotu.ReadOnly = true;
        }


      
    }
}
