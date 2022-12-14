using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace Turkcell_Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolder_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dosya = new FolderBrowserDialog();
            dosya.ShowDialog();

            label2.Text = dosya.SelectedPath;



        }

        private void btn_Open_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.ShowDialog();
            label2.Text = dosya.FileName;

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosya = new SaveFileDialog();
            dosya.ShowDialog();
        }

        string dosyaAd, DosyaYolu;

        private void btn_Dosya_Olustur_Click(object sender, EventArgs e)
        {
            dosyaAd = txt_belge_Ad.Text;
            StreamWriter sw = File.CreateText(DosyaYolu + "\\" + dosyaAd + ".txt");

            MessageBox.Show("Dosyanız Oluşturuldu..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDosya_Oku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(dosya.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {

                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void btnDosya_YaZ_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Metin Dosyası|*.txt ";
            kaydet.ShowDialog();
            StreamWriter yazikaydet = new StreamWriter(kaydet.FileName);
            yazikaydet.WriteLine(richTextBox1.Text);
            yazikaydet.Close();

            MessageBox.Show("Yazınız Başarıyla Kaydedildi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // richTextBox1.Clear();


        }

        private void btnForm2git_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
           this.Hide();
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            /*
            FolderBrowserDialog dosya = new FolderBrowserDialog();
            dosya.ShowDialog();
            txtbelge_yol.Text = dosya.SelectedPath;
            */
            FolderBrowserDialog dosya = new FolderBrowserDialog();

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = dosya.SelectedPath;
                txtbelge_yol.Text = DosyaYolu;


            }
        }
    }
}
