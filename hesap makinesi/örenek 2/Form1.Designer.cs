namespace örenek_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.Topla = new System.Windows.Forms.Button();
            this.Cıkarma = new System.Windows.Forms.Button();
            this.Carpma = new System.Windows.Forms.Button();
            this.Bolme = new System.Windows.Forms.Button();
            this.Kalan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayi 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(64, 75);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(100, 20);
            this.txtSayi3.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(64, 40);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(64, 6);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 5;
            // 
            // Topla
            // 
            this.Topla.Location = new System.Drawing.Point(12, 111);
            this.Topla.Name = "Topla";
            this.Topla.Size = new System.Drawing.Size(75, 27);
            this.Topla.TabIndex = 6;
            this.Topla.Text = "Toplama";
            this.Topla.UseVisualStyleBackColor = true;
            this.Topla.Click += new System.EventHandler(this.Topla_Click);
            // 
            // Cıkarma
            // 
            this.Cıkarma.Location = new System.Drawing.Point(93, 111);
            this.Cıkarma.Name = "Cıkarma";
            this.Cıkarma.Size = new System.Drawing.Size(75, 27);
            this.Cıkarma.TabIndex = 7;
            this.Cıkarma.Text = "Çıkarma";
            this.Cıkarma.UseVisualStyleBackColor = true;
            this.Cıkarma.Click += new System.EventHandler(this.Cıkarma_Click);
            // 
            // Carpma
            // 
            this.Carpma.Location = new System.Drawing.Point(12, 154);
            this.Carpma.Name = "Carpma";
            this.Carpma.Size = new System.Drawing.Size(75, 28);
            this.Carpma.TabIndex = 8;
            this.Carpma.Text = "Çarpma";
            this.Carpma.UseVisualStyleBackColor = true;
            this.Carpma.Click += new System.EventHandler(this.Carpma_Click);
            // 
            // Bolme
            // 
            this.Bolme.Location = new System.Drawing.Point(93, 154);
            this.Bolme.Name = "Bolme";
            this.Bolme.Size = new System.Drawing.Size(75, 28);
            this.Bolme.TabIndex = 9;
            this.Bolme.Text = "Bölme";
            this.Bolme.UseVisualStyleBackColor = true;
            this.Bolme.Click += new System.EventHandler(this.Bolme_Click);
            // 
            // Kalan
            // 
            this.Kalan.Location = new System.Drawing.Point(50, 191);
            this.Kalan.Name = "Kalan";
            this.Kalan.Size = new System.Drawing.Size(75, 23);
            this.Kalan.TabIndex = 10;
            this.Kalan.Text = "Kalan";
            this.Kalan.UseVisualStyleBackColor = true;
            this.Kalan.Click += new System.EventHandler(this.Kalan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(174, 226);
            this.Controls.Add(this.Kalan);
            this.Controls.Add(this.Bolme);
            this.Controls.Add(this.Carpma);
            this.Controls.Add(this.Cıkarma);
            this.Controls.Add(this.Topla);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button Topla;
        private System.Windows.Forms.Button Cıkarma;
        private System.Windows.Forms.Button Carpma;
        private System.Windows.Forms.Button Bolme;
        private System.Windows.Forms.Button Kalan;
    }
}

