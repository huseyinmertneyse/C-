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
            if (int.Parse(txtNotu.Text)>=0 && int.Parse(txtNotu.Text)<50)
            {
                label2.Text = "KALDI";
            }
            else if (int.Parse(txtNotu.Text) >= 50 && int.Parse(txtNotu.Text) <= 100)
            {
                label2.Text = "GEÇTİ";
            }
            else
            {
                label2.Text = "GEÇERSİZ NOT";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "HOŞGELDİNİZ";
        }
    }
}
