using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayactek = 0, sayaccift = 0, toplamcift = 0, toplamtek = 0;
            Random uret = new Random();
            lstTekSayi.Items.Clear(); lstSayi.Items.Clear(); lstCiftSayi.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int uretilensayi = uret.Next(1,100);
                lstSayi.Items.Add(uretilensayi.ToString());
                if (uretilensayi%2==1)
                {
                    sayactek++;
                    lstTekSayi.Items.Add(uretilensayi.ToString());
                    toplamtek += uretilensayi;
                }
                else
                {
                    sayaccift++;
                    lstCiftSayi.Items.Add(uretilensayi.ToString());
                    toplamcift += uretilensayi;
                }
            }
                lblsayactek.Text = sayactek.ToString() + " Tek Sayı";
                lblsayaccift.Text = sayaccift.ToString() + " Tek Sayı";
                lbltoplamcift.Text = toplamcift.ToString();
                lbltoplamtek.Text = toplamtek.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsayactek.Text = "";
            lblsayaccift.Text = "";
            lbltoplamcift.Text = "";
        }
    }
}
