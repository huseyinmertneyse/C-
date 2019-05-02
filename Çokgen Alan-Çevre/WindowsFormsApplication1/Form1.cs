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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblakenar.Visible = false;
            lblbkenar.Visible = false;
            lblckenar.Visible = false;
            lblYukseklik.Visible = false;
            lblYaricap1.Visible = false;
            lblYaricap2.Visible = false;
            lbldkenar.Visible = false;
            txtakenar.Visible = false;
            txtbkenar.Visible = false;
            txtckenar.Visible = false;
            txtYukseklik.Visible = false;
            txtYaricap1.Visible = false;
            txtYaricap2.Visible = false;
            txtdkenar.Visible = false;
            
            if (cmbCokgen.Text=="Çember")
            {
                lblYaricap1.Visible = true;
                txtYaricap1.Visible = true;
            }
            if (cmbCokgen.Text=="Çeşitkenar Üçgen")
            {
                lblakenar.Visible = true;
                lblbkenar.Visible = true;
                lblckenar.Visible = true;
                lblYukseklik.Visible = true;
                txtakenar.Visible = true;
                txtbkenar.Visible = true;
                txtckenar.Visible = true;
                txtYukseklik.Visible = true;
            }
            if (cmbCokgen.Text == "Dikdörtgen")
            {
                lblakenar.Visible = true;
                lblbkenar.Visible = true;
                txtakenar.Visible = true;
                txtbkenar.Visible = true;
            }
            if (cmbCokgen.Text == "Elips")
            {
                lblYaricap1.Visible = true;
                lblYaricap2.Visible = true;
                txtYaricap1.Visible = true;
                txtYaricap2.Visible = true;
            }
            if (cmbCokgen.Text == "Eşkenar Üçgen")
            {
                lblakenar.Visible = true;
                txtakenar.Visible = true;
            }
            if (cmbCokgen.Text == "Kare")
            {
                lblakenar.Visible = true;
                txtakenar.Visible = true; 
            }
            if (cmbCokgen.Text == "Paralel Kenar")
            {
                lblakenar.Visible = true;
                lblbkenar.Visible = true;
                lblYukseklik.Visible = true;
                txtakenar.Visible = true;
                txtbkenar.Visible = true;
                txtYukseklik.Visible = true;
            }
            if (cmbCokgen.Text == "Yamuk")
            {
                lblakenar.Visible = true;
                lblbkenar.Visible = true;
                lblckenar.Visible = true;
                lbldkenar.Visible = true;
                lblYukseklik.Visible = true;
                txtakenar.Visible = true;
                txtbkenar.Visible = true;
                txtckenar.Visible = true;
                txtdkenar.Visible = true;
                txtYukseklik.Visible = true;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Alan = 0, Cevre = 0;
            lblAlan.Text = "";
            lblCevre.Text = "";
            if (cmbCokgen.Text == "Çember")
            {
                double r = 0;
                r = int.Parse(txtYaricap1.Text);
                Alan = Math.PI * (r * r);
                Cevre = 2 * Math.PI * r;
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Çeşitkenar Üçgen")
            {
                int a = int.Parse(txtakenar.Text);
                int b = int.Parse(txtbkenar.Text);
                int c = int.Parse(txtckenar.Text);
                int h = int.Parse(txtYukseklik.Text);
                Alan = (a * h) / 2;
                Cevre = a + b + c;
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Dikdörtgen")
            {
                int a = int.Parse(txtakenar.Text);
                int b = int.Parse(txtbkenar.Text);
                Alan = a * b;
                Cevre = 2 * (a + b);
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Elips")
            {
                double r1 = 0, r2 = 0;
                r1 = int.Parse(txtYaricap1.Text);
                r2 = int.Parse(txtYaricap2.Text);
                Alan = Math.PI * r1 * r2;
                Cevre = (2 * Math.PI) * (Math.Sqrt(((r1 * r1) + (r2 * r2))/2));
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Eşkenar Üçgen")
            {
                int a = int.Parse(txtakenar.Text);
                Alan =(a*a)*Math.Sqrt(3)/4;
                Cevre = 3 * a;
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Kare")
            {
                int a = int.Parse(txtakenar.Text);
                Alan = a*a;
                Cevre = 4 * a;
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Paralel Kenar")
            {
                int a = int.Parse(txtakenar.Text);
                int b = int.Parse(txtbkenar.Text);
                int h = int.Parse(txtYukseklik.Text);
                Alan = b*h;
                Cevre = 2*(a+b);
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            if (cmbCokgen.Text == "Yamuk")
            {
                int a = int.Parse(txtakenar.Text);
                int b = int.Parse(txtbkenar.Text);
                int c = int.Parse(txtckenar.Text);
                int d = int.Parse(txtdkenar.Text);
                int h = int.Parse(txtYukseklik.Text);
                Alan = ((a+d)*h)/2;
                Cevre = a + b + c + d;
                lblAlan.Text = Alan.ToString();
                lblCevre.Text = Cevre.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAlan.Text = "";
            lblCevre.Text = "";
            lblakenar.Visible = false;
            lblbkenar.Visible = false;
            lblckenar.Visible = false;
            lblYukseklik.Visible = false;
            lblYaricap1.Visible = false;
            lblYaricap2.Visible = false;
            lbldkenar.Visible = false;
            txtakenar.Visible = false;
            txtbkenar.Visible = false;
            txtckenar.Visible = false;
            txtYukseklik.Visible = false;
            txtYaricap1.Visible = false;
            txtYaricap2.Visible = false;
            txtdkenar.Visible = false;
        }


        
    }
}
