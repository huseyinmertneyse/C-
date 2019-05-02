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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGirilensayi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFaktöriyel = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Sayı Giriniz";
            // 
            // txtGirilensayi
            // 
            this.txtGirilensayi.Location = new System.Drawing.Point(133, 30);
            this.txtGirilensayi.Name = "txtGirilensayi";
            this.txtGirilensayi.Size = new System.Drawing.Size(100, 22);
            this.txtGirilensayi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFaktöriyel
            // 
            this.lblFaktöriyel.AutoSize = true;
            this.lblFaktöriyel.Location = new System.Drawing.Point(47, 132);
            this.lblFaktöriyel.Name = "lblFaktöriyel";
            this.lblFaktöriyel.Size = new System.Drawing.Size(12, 17);
            this.lblFaktöriyel.TabIndex = 3;
            this.lblFaktöriyel.Text = " ";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(65, 132);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(80, 17);
            this.lblDeger.TabIndex = 4;
            this.lblDeger.Text = "                  ";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblFaktöriyel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGirilensayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirilensayi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFaktöriyel;
        private System.Windows.Forms.Label lblDeger;
    }
}

