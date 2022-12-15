namespace Turkcell_Ders1
{
    partial class Ogrenci_Kayit
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCizgiCiz = new System.Windows.Forms.Button();
            this.btnSayac = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(126, 26);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(146, 26);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Algoritma",
            "Yapay Zeka",
            "Yazılım",
            "Web Tasarım"});
            this.cmbDers.Location = new System.Drawing.Point(126, 63);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(146, 28);
            this.cmbDers.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(380, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(380, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(380, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sınav 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(549, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ortalama:";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(460, 20);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(80, 26);
            this.txtSinav1.TabIndex = 8;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(460, 60);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(80, 26);
            this.txtSinav2.TabIndex = 9;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(460, 94);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(80, 26);
            this.txtSinav3.TabIndex = 10;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Location = new System.Drawing.Point(642, 33);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(119, 26);
            this.txtOrtalama.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(678, 184);
            this.listBox1.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(66, 158);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 35);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(164, 158);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(79, 35);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(261, 158);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 35);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Location = new System.Drawing.Point(642, 65);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(119, 26);
            this.txtDurum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(566, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numara:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(126, 103);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 26);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // btnCizgiCiz
            // 
            this.btnCizgiCiz.Location = new System.Drawing.Point(364, 158);
            this.btnCizgiCiz.Name = "btnCizgiCiz";
            this.btnCizgiCiz.Size = new System.Drawing.Size(89, 35);
            this.btnCizgiCiz.TabIndex = 20;
            this.btnCizgiCiz.Text = "Çizgi Çiz";
            this.btnCizgiCiz.UseVisualStyleBackColor = true;
            this.btnCizgiCiz.Click += new System.EventHandler(this.btnCizgiCiz_Click);
            // 
            // btnSayac
            // 
            this.btnSayac.Location = new System.Drawing.Point(475, 158);
            this.btnSayac.Name = "btnSayac";
            this.btnSayac.Size = new System.Drawing.Size(89, 35);
            this.btnSayac.TabIndex = 21;
            this.btnSayac.Text = "Sayaç";
            this.btnSayac.UseVisualStyleBackColor = true;
            this.btnSayac.Click += new System.EventHandler(this.btnSayac_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(732, 9);
            this.lblSayac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(19, 20);
            this.lblSayac.TabIndex = 22;
            this.lblSayac.Text = "0";
            // 
            // Ogrenci_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(776, 435);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnSayac);
            this.Controls.Add(this.btnCizgiCiz);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtSinav3);
            this.Controls.Add(this.txtSinav2);
            this.Controls.Add(this.txtSinav1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Ogrenci_Kayit";
            this.Text = "Ögrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Ogrenci_Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnCizgiCiz;
        private System.Windows.Forms.Button btnSayac;
        private System.Windows.Forms.Label lblSayac;
    }
}