namespace Turkcell_Ders1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnForm1Git = new System.Windows.Forms.Button();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKod1 = new System.Windows.Forms.TextBox();
            this.txtKod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnForm1Git
            // 
            this.btnForm1Git.Location = new System.Drawing.Point(3, 12);
            this.btnForm1Git.Name = "btnForm1Git";
            this.btnForm1Git.Size = new System.Drawing.Size(75, 23);
            this.btnForm1Git.TabIndex = 5;
            this.btnForm1Git.Text = "form 1\'e git";
            this.btnForm1Git.UseVisualStyleBackColor = true;
            this.btnForm1Git.Click += new System.EventHandler(this.btnForm1Git_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(250, 87);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(202, 29);
            this.txtKullaniciAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(250, 214);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(133, 37);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(175, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(250, 131);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(202, 29);
            this.txtKullaniciSifre.TabIndex = 1;
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // txtKod1
            // 
            this.txtKod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod1.Location = new System.Drawing.Point(250, 166);
            this.txtKod1.Name = "txtKod1";
            this.txtKod1.Size = new System.Drawing.Size(98, 29);
            this.txtKod1.TabIndex = 2;
            // 
            // txtKod2
            // 
            this.txtKod2.Enabled = false;
            this.txtKod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod2.Location = new System.Drawing.Point(354, 166);
            this.txtKod2.Name = "txtKod2";
            this.txtKod2.Size = new System.Drawing.Size(98, 29);
            this.txtKod2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kod Girin:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "Admin login Girişi";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(554, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKod2);
            this.Controls.Add(this.txtKod1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.btnForm1Git);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm1Git;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKod1;
        private System.Windows.Forms.TextBox txtKod2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}