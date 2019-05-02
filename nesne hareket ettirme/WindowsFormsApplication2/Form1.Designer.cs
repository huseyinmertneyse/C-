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
            this.ARTTIR = new System.Windows.Forms.Button();
            this.AZALT = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ARTTIR
            // 
            this.ARTTIR.Location = new System.Drawing.Point(107, 206);
            this.ARTTIR.Name = "ARTTIR";
            this.ARTTIR.Size = new System.Drawing.Size(75, 23);
            this.ARTTIR.TabIndex = 1;
            this.ARTTIR.Text = "SOL";
            this.ARTTIR.UseVisualStyleBackColor = true;
            this.ARTTIR.Click += new System.EventHandler(this.ARTTIR_Click);
            // 
            // AZALT
            // 
            this.AZALT.Location = new System.Drawing.Point(188, 206);
            this.AZALT.Name = "AZALT";
            this.AZALT.Size = new System.Drawing.Size(75, 23);
            this.AZALT.TabIndex = 2;
            this.AZALT.Text = "SAĞ";
            this.AZALT.UseVisualStyleBackColor = true;
            this.AZALT.Click += new System.EventHandler(this.AZALT_Click);
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(163, 48);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(46, 35);
            this.u.TabIndex = 3;
            this.u.Text = "+++   -----";
            this.u.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "AŞAĞI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "YUKARI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.u);
            this.Controls.Add(this.AZALT);
            this.Controls.Add(this.ARTTIR);
            this.Name = "Form1";
            this.Text = "+++   ---";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ARTTIR;
        private System.Windows.Forms.Button AZALT;
        private System.Windows.Forms.Button u;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

