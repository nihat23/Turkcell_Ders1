using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkcell_Ders1
{
    public partial class Ogrenci_Kayit : Form
    {
        public Ogrenci_Kayit()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            string durum;

            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            txtOrtalama.Text = ort.ToString();
            txtOrtalama.ForeColor = Color.Red;

            if (ort >= 50)
            {
                durum = "Geçti..";
            }
            else
            {
                durum = "Kaldı";
            }
            txtDurum.Text = durum;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adsoyad, ders, numara;
            adsoyad = txtAdSoyad.Text;
            ders = cmbDers.Text;
            numara = maskedTextBox1.Text;

            listBox1.Items.Add("Adı Soyadı:" + adsoyad + " Ders:" + ders + " Numara:" + numara + " Ortalama:" + txtOrtalama.Text + " Durumu:" + txtDurum.Text);
        }

        private void Ogrenci_Kayit_Load(object sender, EventArgs e)
        {

        }

        private void btnCizgiCiz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("-----------------------------------------------------------------------------------------------------");
        }

        int sayac = 0;

        private void btnSayac_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text = sayac.ToString();


        }
    }
}
