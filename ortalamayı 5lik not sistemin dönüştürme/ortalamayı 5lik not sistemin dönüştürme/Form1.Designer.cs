namespace ortalamayı_5lik_not_sistemin_dönüştürme
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
            this.txt1not = new System.Windows.Forms.TextBox();
            this.txt2not = new System.Windows.Forms.TextBox();
            this.txtSozlu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Notu = new System.Windows.Forms.Label();
            this.txtNotu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Not";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sözlü";
            // 
            // txt1not
            // 
            this.txt1not.Location = new System.Drawing.Point(92, 6);
            this.txt1not.Name = "txt1not";
            this.txt1not.Size = new System.Drawing.Size(100, 20);
            this.txt1not.TabIndex = 3;
            // 
            // txt2not
            // 
            this.txt2not.Location = new System.Drawing.Point(92, 37);
            this.txt2not.Name = "txt2not";
            this.txt2not.Size = new System.Drawing.Size(100, 20);
            this.txt2not.TabIndex = 4;
            // 
            // txtSozlu
            // 
            this.txtSozlu.Location = new System.Drawing.Point(92, 70);
            this.txtSozlu.Name = "txtSozlu";
            this.txtSozlu.Size = new System.Drawing.Size(100, 20);
            this.txtSozlu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ortalama";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(92, 101);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notu
            // 
            this.Notu.AutoSize = true;
            this.Notu.Location = new System.Drawing.Point(8, 135);
            this.Notu.Name = "Notu";
            this.Notu.Size = new System.Drawing.Size(30, 13);
            this.Notu.TabIndex = 9;
            this.Notu.Text = "Notu";
            // 
            // txtNotu
            // 
            this.txtNotu.Location = new System.Drawing.Point(92, 132);
            this.txtNotu.Name = "txtNotu";
            this.txtNotu.Size = new System.Drawing.Size(100, 20);
            this.txtNotu.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 218);
            this.Controls.Add(this.txtNotu);
            this.Controls.Add(this.Notu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSozlu);
            this.Controls.Add(this.txt2not);
            this.Controls.Add(this.txt1not);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1not;
        private System.Windows.Forms.TextBox txt2not;
        private System.Windows.Forms.TextBox txtSozlu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Notu;
        private System.Windows.Forms.TextBox txtNotu;
    }
}

