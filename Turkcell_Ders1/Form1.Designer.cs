namespace Turkcell_Ders1
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
            this.btnFolder_Browser = new System.Windows.Forms.Button();
            this.btn_Open_File = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtbelge_yol = new System.Windows.Forms.TextBox();
            this.txt_belge_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Dosya_Olustur = new System.Windows.Forms.Button();
            this.btnKonumSec = new System.Windows.Forms.Button();
            this.btnDosya_Oku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDosya_YaZ = new System.Windows.Forms.Button();
            this.btnForm2git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFolder_Browser
            // 
            this.btnFolder_Browser.Location = new System.Drawing.Point(413, 23);
            this.btnFolder_Browser.Name = "btnFolder_Browser";
            this.btnFolder_Browser.Size = new System.Drawing.Size(159, 23);
            this.btnFolder_Browser.TabIndex = 0;
            this.btnFolder_Browser.Text = "Folder Browser";
            this.btnFolder_Browser.UseVisualStyleBackColor = true;
            this.btnFolder_Browser.Click += new System.EventHandler(this.btnFolder_Browser_Click);
            // 
            // btn_Open_File
            // 
            this.btn_Open_File.Location = new System.Drawing.Point(413, 65);
            this.btn_Open_File.Name = "btn_Open_File";
            this.btn_Open_File.Size = new System.Drawing.Size(159, 23);
            this.btn_Open_File.TabIndex = 1;
            this.btn_Open_File.Text = "Open Fille";
            this.btn_Open_File.UseVisualStyleBackColor = true;
            this.btn_Open_File.Click += new System.EventHandler(this.btn_Open_File_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seçilen yol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "_";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(413, 111);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(159, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save Fille";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtbelge_yol
            // 
            this.txtbelge_yol.Location = new System.Drawing.Point(117, 22);
            this.txtbelge_yol.Name = "txtbelge_yol";
            this.txtbelge_yol.Size = new System.Drawing.Size(244, 20);
            this.txtbelge_yol.TabIndex = 5;
            // 
            // txt_belge_Ad
            // 
            this.txt_belge_Ad.Location = new System.Drawing.Point(117, 64);
            this.txt_belge_Ad.Name = "txt_belge_Ad";
            this.txt_belge_Ad.Size = new System.Drawing.Size(244, 20);
            this.txt_belge_Ad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Belge Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Belge Yolu:";
            // 
            // btn_Dosya_Olustur
            // 
            this.btn_Dosya_Olustur.Location = new System.Drawing.Point(413, 198);
            this.btn_Dosya_Olustur.Name = "btn_Dosya_Olustur";
            this.btn_Dosya_Olustur.Size = new System.Drawing.Size(159, 23);
            this.btn_Dosya_Olustur.TabIndex = 10;
            this.btn_Dosya_Olustur.Text = "Dosya Oluştur";
            this.btn_Dosya_Olustur.UseVisualStyleBackColor = true;
            this.btn_Dosya_Olustur.Click += new System.EventHandler(this.btn_Dosya_Olustur_Click);
            // 
            // btnKonumSec
            // 
            this.btnKonumSec.Location = new System.Drawing.Point(413, 152);
            this.btnKonumSec.Name = "btnKonumSec";
            this.btnKonumSec.Size = new System.Drawing.Size(159, 23);
            this.btnKonumSec.TabIndex = 9;
            this.btnKonumSec.Text = "Konum Seç";
            this.btnKonumSec.UseVisualStyleBackColor = true;
            this.btnKonumSec.Click += new System.EventHandler(this.btnKonumSec_Click);
            // 
            // btnDosya_Oku
            // 
            this.btnDosya_Oku.Location = new System.Drawing.Point(413, 240);
            this.btnDosya_Oku.Name = "btnDosya_Oku";
            this.btnDosya_Oku.Size = new System.Drawing.Size(159, 23);
            this.btnDosya_Oku.TabIndex = 11;
            this.btnDosya_Oku.Text = "Dosya oku";
            this.btnDosya_Oku.UseVisualStyleBackColor = true;
            this.btnDosya_Oku.Click += new System.EventHandler(this.btnDosya_Oku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(53, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 108);
            this.listBox1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 119);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // btnDosya_YaZ
            // 
            this.btnDosya_YaZ.Location = new System.Drawing.Point(413, 283);
            this.btnDosya_YaZ.Name = "btnDosya_YaZ";
            this.btnDosya_YaZ.Size = new System.Drawing.Size(159, 23);
            this.btnDosya_YaZ.TabIndex = 14;
            this.btnDosya_YaZ.Text = "Dosya Yaz";
            this.btnDosya_YaZ.UseVisualStyleBackColor = true;
            this.btnDosya_YaZ.Click += new System.EventHandler(this.btnDosya_YaZ_Click);
            // 
            // btnForm2git
            // 
            this.btnForm2git.Location = new System.Drawing.Point(413, 327);
            this.btnForm2git.Name = "btnForm2git";
            this.btnForm2git.Size = new System.Drawing.Size(159, 23);
            this.btnForm2git.TabIndex = 15;
            this.btnForm2git.Text = "Form 2ye Git";
            this.btnForm2git.UseVisualStyleBackColor = true;
            this.btnForm2git.Click += new System.EventHandler(this.btnForm2git_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 384);
            this.Controls.Add(this.btnForm2git);
            this.Controls.Add(this.btnDosya_YaZ);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDosya_Oku);
            this.Controls.Add(this.btn_Dosya_Olustur);
            this.Controls.Add(this.btnKonumSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_belge_Ad);
            this.Controls.Add(this.txtbelge_yol);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Open_File);
            this.Controls.Add(this.btnFolder_Browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolder_Browser;
        private System.Windows.Forms.Button btn_Open_File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtbelge_yol;
        private System.Windows.Forms.TextBox txt_belge_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Dosya_Olustur;
        private System.Windows.Forms.Button btnKonumSec;
        private System.Windows.Forms.Button btnDosya_Oku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDosya_YaZ;
        private System.Windows.Forms.Button btnForm2git;
    }
}

