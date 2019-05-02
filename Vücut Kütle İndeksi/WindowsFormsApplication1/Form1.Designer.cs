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
            this.label2 = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblYazdır = new System.Windows.Forms.Label();
            this.lblSinir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boy:";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(30, 127);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(49, 17);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "İndex=";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(71, 26);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(51, 22);
            this.txtKilo.TabIndex = 3;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(72, 54);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(50, 22);
            this.txtBoy.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ölç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(85, 127);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 17);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "           ";
            // 
            // lblYazdır
            // 
            this.lblYazdır.AutoSize = true;
            this.lblYazdır.Location = new System.Drawing.Point(30, 167);
            this.lblYazdır.Name = "lblYazdır";
            this.lblYazdır.Size = new System.Drawing.Size(36, 17);
            this.lblYazdır.TabIndex = 7;
            this.lblYazdır.Text = "       ";
            // 
            // lblSinir
            // 
            this.lblSinir.AutoSize = true;
            this.lblSinir.Location = new System.Drawing.Point(30, 220);
            this.lblSinir.Name = "lblSinir";
            this.lblSinir.Size = new System.Drawing.Size(48, 17);
            this.lblSinir.TabIndex = 8;
            this.lblSinir.Text = "          ";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblSinir);
            this.Controls.Add(this.lblYazdır);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblYazdır;
        private System.Windows.Forms.Label lblSinir;
    }
}

