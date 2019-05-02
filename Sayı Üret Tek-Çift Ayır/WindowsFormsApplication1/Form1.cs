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
            Random r = new Random();

            for (int i = 1; i <= 10; i++)
            {
                
                int sayi = r.Next(1, 100);

                lstSayilar.Items.Add(sayi.ToString());
               
                if (sayi%2==0)
                {
                    lstCiftsayilar.Items.Add(sayi.ToString());
                }
                else
                {
                    lstTeksayilar.Items.Add(sayi.ToString());
                }
                
            }
        }

      
    }
}
