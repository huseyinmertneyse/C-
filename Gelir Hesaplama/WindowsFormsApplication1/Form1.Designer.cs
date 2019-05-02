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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrutMaas = new System.Windows.Forms.TextBox();
            this.txtMesaiSaati = new System.Windows.Forms.TextBox();
            this.txtCocukSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCocukSayisi = new System.Windows.Forms.Label();
            this.radioEvli = new System.Windows.Forms.RadioButton();
            this.radioBekar = new System.Windows.Forms.RadioButton();
            this.cmbVergiDilimi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrutEk = new System.Windows.Forms.TextBox();
            this.txtNetEk = new System.Windows.Forms.TextBox();
            this.txtNetMaas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBrutMaas
            // 
            resources.ApplyResources(this.txtBrutMaas, "txtBrutMaas");
            this.txtBrutMaas.Name = "txtBrutMaas";
            // 
            // txtMesaiSaati
            // 
            resources.ApplyResources(this.txtMesaiSaati, "txtMesaiSaati");
            this.txtMesaiSaati.Name = "txtMesaiSaati";
            // 
            // txtCocukSayisi
            // 
            resources.ApplyResources(this.txtCocukSayisi, "txtCocukSayisi");
            this.txtCocukSayisi.Name = "txtCocukSayisi";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblCocukSayisi
            // 
            resources.ApplyResources(this.lblCocukSayisi, "lblCocukSayisi");
            this.lblCocukSayisi.Name = "lblCocukSayisi";
            // 
            // radioEvli
            // 
            resources.ApplyResources(this.radioEvli, "radioEvli");
            this.radioEvli.Name = "radioEvli";
            this.radioEvli.TabStop = true;
            this.radioEvli.UseVisualStyleBackColor = true;
            this.radioEvli.CheckedChanged += new System.EventHandler(this.radioEvli_CheckedChanged);
            // 
            // radioBekar
            // 
            resources.ApplyResources(this.radioBekar, "radioBekar");
            this.radioBekar.Name = "radioBekar";
            this.radioBekar.TabStop = true;
            this.radioBekar.UseVisualStyleBackColor = true;
            this.radioBekar.CheckedChanged += new System.EventHandler(this.radioBekar_CheckedChanged);
            // 
            // cmbVergiDilimi
            // 
            this.cmbVergiDilimi.FormattingEnabled = true;
            this.cmbVergiDilimi.Items.AddRange(new object[] {
            resources.GetString("cmbVergiDilimi.Items"),
            resources.GetString("cmbVergiDilimi.Items1"),
            resources.GetString("cmbVergiDilimi.Items2"),
            resources.GetString("cmbVergiDilimi.Items3")});
            resources.ApplyResources(this.cmbVergiDilimi, "cmbVergiDilimi");
            this.cmbVergiDilimi.Name = "cmbVergiDilimi";
            this.cmbVergiDilimi.SelectedIndexChanged += new System.EventHandler(this.cmbVergiDilimi_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtBrutEk
            // 
            resources.ApplyResources(this.txtBrutEk, "txtBrutEk");
            this.txtBrutEk.Name = "txtBrutEk";
            // 
            // txtNetEk
            // 
            resources.ApplyResources(this.txtNetEk, "txtNetEk");
            this.txtNetEk.Name = "txtNetEk";
            // 
            // txtNetMaas
            // 
            resources.ApplyResources(this.txtNetMaas, "txtNetMaas");
            this.txtNetMaas.Name = "txtNetMaas";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtToplamOdeme
            // 
            resources.ApplyResources(this.txtToplamOdeme, "txtToplamOdeme");
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNetMaas);
            this.Controls.Add(this.txtNetEk);
            this.Controls.Add(this.txtBrutEk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVergiDilimi);
            this.Controls.Add(this.radioBekar);
            this.Controls.Add(this.radioEvli);
            this.Controls.Add(this.lblCocukSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCocukSayisi);
            this.Controls.Add(this.txtMesaiSaati);
            this.Controls.Add(this.txtBrutMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrutMaas;
        private System.Windows.Forms.TextBox txtMesaiSaati;
        private System.Windows.Forms.TextBox txtCocukSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCocukSayisi;
        private System.Windows.Forms.RadioButton radioEvli;
        private System.Windows.Forms.RadioButton radioBekar;
        private System.Windows.Forms.ComboBox cmbVergiDilimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrutEk;
        private System.Windows.Forms.TextBox txtNetEk;
        private System.Windows.Forms.TextBox txtNetMaas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToplamOdeme;
        private System.Windows.Forms.Button button1;
    }
}

