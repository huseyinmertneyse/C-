namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstSayi = new System.Windows.Forms.ListBox();
            this.lstTekSayi = new System.Windows.Forms.ListBox();
            this.lstCiftSayi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsayactek = new System.Windows.Forms.Label();
            this.lblsayaccift = new System.Windows.Forms.Label();
            this.lbltoplamcift = new System.Windows.Forms.Label();
            this.lbltoplamtek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSayi
            // 
            this.lstSayi.FormattingEnabled = true;
            this.lstSayi.Location = new System.Drawing.Point(12, 80);
            this.lstSayi.Name = "lstSayi";
            this.lstSayi.Size = new System.Drawing.Size(75, 134);
            this.lstSayi.TabIndex = 1;
            // 
            // lstTekSayi
            // 
            this.lstTekSayi.FormattingEnabled = true;
            this.lstTekSayi.Location = new System.Drawing.Point(105, 80);
            this.lstTekSayi.Name = "lstTekSayi";
            this.lstTekSayi.Size = new System.Drawing.Size(75, 134);
            this.lstTekSayi.TabIndex = 2;
            // 
            // lstCiftSayi
            // 
            this.lstCiftSayi.FormattingEnabled = true;
            this.lstCiftSayi.Location = new System.Drawing.Point(197, 80);
            this.lstCiftSayi.Name = "lstCiftSayi";
            this.lstCiftSayi.Size = new System.Drawing.Size(75, 134);
            this.lstCiftSayi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çift Sayılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tek Sayılar";
            // 
            // lblsayactek
            // 
            this.lblsayactek.AutoSize = true;
            this.lblsayactek.Location = new System.Drawing.Point(113, 217);
            this.lblsayactek.Name = "lblsayactek";
            this.lblsayactek.Size = new System.Drawing.Size(35, 13);
            this.lblsayactek.TabIndex = 7;
            this.lblsayactek.Text = "label4";
            // 
            // lblsayaccift
            // 
            this.lblsayaccift.AutoSize = true;
            this.lblsayaccift.Location = new System.Drawing.Point(203, 217);
            this.lblsayaccift.Name = "lblsayaccift";
            this.lblsayaccift.Size = new System.Drawing.Size(35, 13);
            this.lblsayaccift.TabIndex = 8;
            this.lblsayaccift.Text = "label5";
            // 
            // lbltoplamcift
            // 
            this.lbltoplamcift.AutoSize = true;
            this.lbltoplamcift.Location = new System.Drawing.Point(113, 244);
            this.lbltoplamcift.Name = "lbltoplamcift";
            this.lbltoplamcift.Size = new System.Drawing.Size(35, 13);
            this.lbltoplamcift.TabIndex = 9;
            this.lbltoplamcift.Text = "label4";
            // 
            // lbltoplamtek
            // 
            this.lbltoplamtek.AutoSize = true;
            this.lbltoplamtek.Location = new System.Drawing.Point(203, 244);
            this.lbltoplamtek.Name = "lbltoplamtek";
            this.lbltoplamtek.Size = new System.Drawing.Size(35, 13);
            this.lbltoplamtek.TabIndex = 10;
            this.lbltoplamtek.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.lbltoplamtek);
            this.Controls.Add(this.lbltoplamcift);
            this.Controls.Add(this.lblsayaccift);
            this.Controls.Add(this.lblsayactek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCiftSayi);
            this.Controls.Add(this.lstTekSayi);
            this.Controls.Add(this.lstSayi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSayi;
        private System.Windows.Forms.ListBox lstTekSayi;
        private System.Windows.Forms.ListBox lstCiftSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsayactek;
        private System.Windows.Forms.Label lblsayaccift;
        private System.Windows.Forms.Label lbltoplamcift;
        private System.Windows.Forms.Label lbltoplamtek;
    }
}

