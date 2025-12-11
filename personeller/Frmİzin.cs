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
            // EĞER FORM DAHA HAZIR DEĞİLSE HİÇBİR ŞEY YAPMA, GERİ DÖN!
            if (formHazirMi == false) return;

            // Tarihlerin sırasını kontrol et
            if (dateBitis.Value < dateBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateBitis.Value = dateBaslangic.Value; // Tarihi geri düzelt
                return;
            }

            // Hesaplama Fonksiyonunu Çağır
            GunHesapla();
        }

        private void dateBaslangic_ValueChanged(object sender, EventArgs e)
        {
            // EĞER FORM DAHA HAZIR DEĞİLSE HİÇBİR ŞEY YAPMA, GERİ DÖN!
            // (Bu kontrolü buraya da ekledik, hata buradaydı)
            if (formHazirMi == false) return;

            // Tarihlerin sırasını kontrol et
            if (dateBitis.Value < dateBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateBitis.Value = dateBaslangic.Value;
                return;
            }

            // Hesaplama Fonksiyonunu Çağır
            GunHesapla();
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
    }
}