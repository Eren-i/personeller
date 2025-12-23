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
    public partial class Frmİzin : Form
    {
        // Bu değişken formun hazır olup olmadığını kontrol edecek
        bool formHazirMi = false;

        public Frmİzin()
        {
            InitializeComponent();
        }

        private void Frmİzin_Load(object sender, EventArgs e)
        {
            // Önce tarihleri ayarla
            dateBaslangic.Value = DateTime.Now;
            dateBitis.Value = DateTime.Now;
            txtSure.Text = "1";

            // EN SONUNDA: Artık form hazır, hesaplama yapabilirsin de!
            formHazirMi = true;
        }

        private void dateBitis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateBaslangic_ValueChanged(object sender, EventArgs e)
        {

        }

        // Hesaplama işini tek bir ortak metoda aldım, daha temiz oldu
        private void GunHesapla()
        {
            TimeSpan zamanFarki = dateBitis.Value - dateBaslangic.Value;
            int toplamGun = Convert.ToInt32(zamanFarki.TotalDays) + 1;
            txtSure.Text = toplamGun.ToString();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // 1. Doğrulama: Açıklama boş mu?
            if (txtAciklama.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen izin nedeninizi / mazeretinizi yazınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAciklama.Focus();
                return;
            }

            // 2. Doğrulama: Süre 0 veya eksi mi?
            if (txtSure.Text == "0" || txtSure.Text == "")
            {
                MessageBox.Show("Lütfen geçerli bir tarih aralığı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- BURASI VERİTABANI GELİNCE DEĞİŞECEK ---

            MessageBox.Show("İzin talebiniz başarıyla oluşturuldu.", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // BURADAKİ 'this.Close()' ve Temizleme kodlarını SİLDİK.
            // Artık butona basınca sadece mesaj verir, form kapanmaz, yazılar silinmez.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Hedef Formu Tanımla (Gideceğimiz yer: Çalışan Ekranı)
            CalisanEkranı anasayfa = new CalisanEkranı();

            // 2. O formu aç
            anasayfa.Show();

            // 3. Şu anki İzin formunu gizle (Kapatma, gizle ki program çökmesin)
            this.Hide();


            /// BU KOD KESİNLİKLE DEĞİŞMELİDİR KESİNDİR !!!!!!!!!!!!!!!!!!!!!!!
        }

        private void dateBitis_ValueChanged_1(object sender, EventArgs e)
        {
            // dateBaslangic ve dateBitis senin araçlarının adı olsun
            DateTime baslangic = dateBaslangic.Value;
            DateTime bitis = dateBitis.Value;

            TimeSpan fark = bitis - baslangic;
            int gunSayisi = (int)fark.TotalDays;

            if (gunSayisi < 0)
            {
                txtSure.Text = "Hatalı Tarih!";
                txtSure.ForeColor = Color.Red;
            }
            else
            {
                // +1 ekliyoruz çünkü başladığı gün de sayılır
                txtSure.Text = (gunSayisi + 1).ToString() + " GÜN";
                txtSure.ForeColor = Color.DarkBlue;
            }
        }
    }
}