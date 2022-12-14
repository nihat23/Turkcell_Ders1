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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm1Git_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        void kodolustur()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 100000);
            txtKod2.Text = sayi.ToString();


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text == "Admin" && txtKullaniciSifre.Text == "123456" && txtKod1.Text == txtKod2.Text)
            {
                Form3 frm3 = new Form3();
                frm3.kullanici = txtKullaniciAd.Text;
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya sifre veya kod yanlıştır..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            this.Text = "Sayaç:" + sayac.ToString();
            if (sayac % 2 == 0)
            {
                label4.BackColor = Color.YellowGreen;
            }
            else
            {
                label4.BackColor = Color.Coral;
            }
            if (sayac == 15)
            {
                sayac = 0;
            }

        }
    }
}
