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
    public partial class FrmVardiyaa : Form
    {
        public FrmVardiyaa()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVardiyaa_Load(object sender, EventArgs e)
        {
            // Önce paneli temizle (Eski kutular kalmasın)
            flowLayoutPanel1.Controls.Clear();

            // Bugünün tarihini al
            DateTime bugun = DateTime.Now;

            // 7 Günlük Döngü Başlat (Bugün + 6 gün sonrası)
            for (int i = 0; i < 7; i++)
            {
                // Bizim özel Lego parçamızdan (VardiyaKutusu) bir tane üret
                VardiyaKutusu kutu = new VardiyaKutusu();

                // O anki döngüdeki tarihi hesapla
                DateTime oGun = bugun.AddDays(i);

                // --- KUTUNUN İÇİNİ DOLDUR ---
                kutu.GunAdi = oGun.ToString("dddd");        // Gün adı (Pazartesi)
                kutu.Tarih = oGun.ToString("dd.MM.yyyy");   // Tarih (12.12.2025)

                // --- PAZAR GÜNLERİ KIRMIZI OLSUN ---
                if (oGun.DayOfWeek == DayOfWeek.Sunday)
                {
                    kutu.Saat = "İZİNLİ";
                    kutu.DurumAyarla("İZİNLİ"); // Kırmızı yapar
                }
                else
                {
                    kutu.Saat = "09:00 - 18:00";
                    kutu.DurumAyarla("CALISIYOR"); // Yeşil yapar
                }

                // En son kutuyu ekrana (Panele) ekle
                flowLayoutPanel1.Controls.Add(kutu);



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapatır, arkadaki menüye döner.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
