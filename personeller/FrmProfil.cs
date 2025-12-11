using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeller
{
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            // Veritabanı gelene kadar burayı elle dolduruyoruz (Mock Data) Erenden mesaj !!
            // Böylece formu test edebilirsin.

            txtAd.Text = "Ahmet";
            txtSoyad.Text = "Yılmaz";
            labeltc.Text = "12345678901";
            LabelMail.Text = "ahmet@sirket.com";
            labelTelefon.Text = "0555 444 33 22";
            depolabel.Text = "Yazılım Geliştirme";
            txtMaas.Text = "35.000 TL";
            txtAdres.Text = "İstanbul, Kadıköy, ... sokak";

            // Resmi de projenin içinden veya internetten rastgele bir linkle test et
            // pictureBox1.ImageLocation = "";   Burda fotoğraf olucak
        }

        private void btnGuncelle_Click_Click(object sender, EventArgs e)
        {
            // SQL gelince buraya "Update TBL_PERSONEL Set..." yazacağız.
            MessageBox.Show("Bilgileriniz başarıyla güncellendi! (Test Modu)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
