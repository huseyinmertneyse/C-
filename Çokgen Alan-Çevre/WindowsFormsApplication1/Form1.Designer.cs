namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCokgen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.txtakenar = new System.Windows.Forms.TextBox();
            this.txtbkenar = new System.Windows.Forms.TextBox();
            this.txtckenar = new System.Windows.Forms.TextBox();
            this.lblakenar = new System.Windows.Forms.Label();
            this.lblbkenar = new System.Windows.Forms.Label();
            this.lblckenar = new System.Windows.Forms.Label();
            this.lblYukseklik = new System.Windows.Forms.Label();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.txtYaricap1 = new System.Windows.Forms.TextBox();
            this.lblYaricap1 = new System.Windows.Forms.Label();
            this.txtdkenar = new System.Windows.Forms.TextBox();
            this.lbldkenar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblYaricap2 = new System.Windows.Forms.Label();
            this.txtYaricap2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCokgen
            // 
            this.cmbCokgen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCokgen.FormattingEnabled = true;
            this.cmbCokgen.Items.AddRange(new object[] {
            "Çember",
            "Çeşitkenar Üçgen",
            "Dikdörtgen",
            "Elips",
            "Eşkenar Üçgen",
            "Kare",
            "Paralel Kenar",
            "Yamuk"});
            this.cmbCokgen.Location = new System.Drawing.Point(19, 27);
            this.cmbCokgen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCokgen.Name = "cmbCokgen";
            this.cmbCokgen.Size = new System.Drawing.Size(110, 21);
            this.cmbCokgen.TabIndex = 0;
            this.cmbCokgen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çevre";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(23, 50);
            this.lblAlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(27, 13);
            this.lblAlan.TabIndex = 4;
            this.lblAlan.Text = "alan";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(107, 50);
            this.lblCevre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(34, 13);
            this.lblCevre.TabIndex = 5;
            this.lblCevre.Text = "çevre";
            // 
            // txtakenar
            // 
            this.txtakenar.Location = new System.Drawing.Point(53, 101);
            this.txtakenar.Margin = new System.Windows.Forms.Padding(2);
            this.txtakenar.Name = "txtakenar";
            this.txtakenar.Size = new System.Drawing.Size(76, 20);
            this.txtakenar.TabIndex = 6;
            // 
            // txtbkenar
            // 
            this.txtbkenar.Location = new System.Drawing.Point(53, 124);
            this.txtbkenar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbkenar.Name = "txtbkenar";
            this.txtbkenar.Size = new System.Drawing.Size(76, 20);
            this.txtbkenar.TabIndex = 7;
            // 
            // txtckenar
            // 
            this.txtckenar.Location = new System.Drawing.Point(53, 147);
            this.txtckenar.Margin = new System.Windows.Forms.Padding(2);
            this.txtckenar.Name = "txtckenar";
            this.txtckenar.Size = new System.Drawing.Size(76, 20);
            this.txtckenar.TabIndex = 8;
            // 
            // lblakenar
            // 
            this.lblakenar.AutoSize = true;
            this.lblakenar.Location = new System.Drawing.Point(5, 104);
            this.lblakenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblakenar.Name = "lblakenar";
            this.lblakenar.Size = new System.Drawing.Size(44, 13);
            this.lblakenar.TabIndex = 9;
            this.lblakenar.Text = "a.Kenar";
            // 
            // lblbkenar
            // 
            this.lblbkenar.AutoSize = true;
            this.lblbkenar.Location = new System.Drawing.Point(5, 126);
            this.lblbkenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbkenar.Name = "lblbkenar";
            this.lblbkenar.Size = new System.Drawing.Size(44, 13);
            this.lblbkenar.TabIndex = 10;
            this.lblbkenar.Text = "b.Kenar";
            // 
            // lblckenar
            // 
            this.lblckenar.AutoSize = true;
            this.lblckenar.Location = new System.Drawing.Point(5, 149);
            this.lblckenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblckenar.Name = "lblckenar";
            this.lblckenar.Size = new System.Drawing.Size(44, 13);
            this.lblckenar.TabIndex = 11;
            this.lblckenar.Text = "c.Kenar";
            // 
            // lblYukseklik
            // 
            this.lblYukseklik.AutoSize = true;
            this.lblYukseklik.Location = new System.Drawing.Point(141, 104);
            this.lblYukseklik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYukseklik.Name = "lblYukseklik";
            this.lblYukseklik.Size = new System.Drawing.Size(53, 13);
            this.lblYukseklik.TabIndex = 12;
            this.lblYukseklik.Text = "Yükseklik";
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Location = new System.Drawing.Point(196, 101);
            this.txtYukseklik.Margin = new System.Windows.Forms.Padding(2);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(76, 20);
            this.txtYukseklik.TabIndex = 13;
            // 
            // txtYaricap1
            // 
            this.txtYaricap1.Location = new System.Drawing.Point(53, 101);
            this.txtYaricap1.Margin = new System.Windows.Forms.Padding(2);
            this.txtYaricap1.Name = "txtYaricap1";
            this.txtYaricap1.Size = new System.Drawing.Size(76, 20);
            this.txtYaricap1.TabIndex = 14;
            // 
            // lblYaricap1
            // 
            this.lblYaricap1.AutoSize = true;
            this.lblYaricap1.Location = new System.Drawing.Point(0, 104);
            this.lblYaricap1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYaricap1.Name = "lblYaricap1";
            this.lblYaricap1.Size = new System.Drawing.Size(49, 13);
            this.lblYaricap1.TabIndex = 15;
            this.lblYaricap1.Text = "Yarıçap1";
            // 
            // txtdkenar
            // 
            this.txtdkenar.Location = new System.Drawing.Point(53, 169);
            this.txtdkenar.Margin = new System.Windows.Forms.Padding(2);
            this.txtdkenar.Name = "txtdkenar";
            this.txtdkenar.Size = new System.Drawing.Size(76, 20);
            this.txtdkenar.TabIndex = 16;
            // 
            // lbldkenar
            // 
            this.lbldkenar.AutoSize = true;
            this.lbldkenar.Location = new System.Drawing.Point(5, 172);
            this.lbldkenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldkenar.Name = "lbldkenar";
            this.lbldkenar.Size = new System.Drawing.Size(44, 13);
            this.lbldkenar.TabIndex = 17;
            this.lbldkenar.Text = "d.Kenar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Çokgenler";
            // 
            // lblYaricap2
            // 
            this.lblYaricap2.AutoSize = true;
            this.lblYaricap2.Location = new System.Drawing.Point(0, 126);
            this.lblYaricap2.Name = "lblYaricap2";
            this.lblYaricap2.Size = new System.Drawing.Size(49, 13);
            this.lblYaricap2.TabIndex = 21;
            this.lblYaricap2.Text = "Yarıçap2";
            // 
            // txtYaricap2
            // 
            this.txtYaricap2.Location = new System.Drawing.Point(53, 124);
            this.txtYaricap2.Name = "txtYaricap2";
            this.txtYaricap2.Size = new System.Drawing.Size(76, 20);
            this.txtYaricap2.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAlan);
            this.groupBox1.Controls.Add(this.lblCevre);
            this.groupBox1.Location = new System.Drawing.Point(144, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtYaricap2);
            this.Controls.Add(this.lblYaricap2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbldkenar);
            this.Controls.Add(this.txtdkenar);
            this.Controls.Add(this.lblYaricap1);
            this.Controls.Add(this.txtYaricap1);
            this.Controls.Add(this.txtYukseklik);
            this.Controls.Add(this.lblYukseklik);
            this.Controls.Add(this.lblckenar);
            this.Controls.Add(this.lblbkenar);
            this.Controls.Add(this.lblakenar);
            this.Controls.Add(this.txtckenar);
            this.Controls.Add(this.txtbkenar);
            this.Controls.Add(this.txtakenar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCokgen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCokgen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.TextBox txtakenar;
        private System.Windows.Forms.TextBox txtbkenar;
        private System.Windows.Forms.TextBox txtckenar;
        private System.Windows.Forms.Label lblakenar;
        private System.Windows.Forms.Label lblbkenar;
        private System.Windows.Forms.Label lblckenar;
        private System.Windows.Forms.Label lblYukseklik;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.TextBox txtYaricap1;
        private System.Windows.Forms.Label lblYaricap1;
        private System.Windows.Forms.TextBox txtdkenar;
        private System.Windows.Forms.Label lbldkenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblYaricap2;
        private System.Windows.Forms.TextBox txtYaricap2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

