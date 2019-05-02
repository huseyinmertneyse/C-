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
            this.txtPara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(35, 30);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(45, 22);
            this.txtPara.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ayır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(32, 78);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(68, 17);
            this.lblPara.TabIndex = 2;
            this.lblPara.Text = "               ";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPara;

    }
}

