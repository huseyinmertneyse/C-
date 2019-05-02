using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARASINDAKİ_SAYILARI_TOPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,toplam=0;
            

            if (txtSayi1.Text == "" || txtSayi2.Text == "")
            {
                MessageBox.Show("Lütfen Değerlerin Her İkisinide Girin !!! ");
            }
            else if (int.TryParse(txtSayi1.Text, out sayi1) == true && int.TryParse(txtSayi2.Text, out sayi1) == true)
            {
           
                sayi1 = int.Parse(txtSayi1.Text);
                sayi2 = int.Parse(txtSayi2.Text);
                if (rbToplam.Checked == true)
                {
                    if (sayi1 < sayi2)
                    {
                        for (int i = sayi1; i <= sayi2; i++)
                        {
                            toplam = toplam + i;
                        }
                    }
                    else if (sayi1 > sayi2)
                    {
                        for (int i = sayi2; i <= sayi1; i++)
                        {
                            toplam = toplam + i;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Eşit Girmeyiniz !!!");
                    }
                    label3.Text = toplam.ToString();
                }
                else if (rbCift.Checked == true)
                {
                    if (sayi1 < sayi2)
                    {
                        for (int i = sayi1; i <= sayi2; i++)
                        {
                            if (i % 2 == 0)
                            {
                                toplam = toplam + i;
                            }

                        }
                    }
                    else if (sayi1 > sayi2)
                    {
                        for (int i = sayi2; i <= sayi1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                toplam = toplam + i;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Eşit Girmeyiniz !!!");
                    }
                    label3.Text = toplam.ToString();
                }
                else if (rbTek.Checked == true)
                {

                    if (sayi1 < sayi2)
                    {
                        for (int i = sayi1; i <= sayi2; i++)
                        {
                            if (i % 2 == 1)
                            {
                                toplam = toplam + i;
                            }

                        }
                    }
                    else if (sayi1 > sayi2)
                    {
                        for (int i = sayi2; i <= sayi1; i++)
                        {
                            if (i % 2 == 1)
                            {
                                toplam = toplam + i;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Eşit Girmeyiniz !!!");
                    }
                    label3.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Seçenek Seçin");
                }
                
            }
            else
	         {
                 MessageBox.Show("Sayı Girin !!! ");
	         }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
