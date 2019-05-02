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
            int sayi=  int.Parse(txtGirilensayi.Text) ;
            int deger = 1;
            for (int i = 1; i < sayi+1; i++)
            {
                deger = deger * i;
            }
            txtGirilensayi.Text = "";
            lblFaktöriyel.Text = sayi.ToString() + "!=";
            lblDeger.Text = deger.ToString();
        }
    }
}
