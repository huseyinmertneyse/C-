using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adres_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          lblAdres.Text=txtMahalle.Text+" Mahallesi "+txtSokak.Text+" Sokak"+"\n"+txtKapıNo.Text+"/"+txtDaireNo.Text+"\n"+txtIlce.Text+"/"+txtIl.Text; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

