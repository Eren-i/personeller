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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            // DataGridView'e el ile sütun ekleyelim (Veritabanı yokken test için)
            // (Sütun Adı, Ekranda Görünen Yazı)
            dataGridView1.Columns.Add("Gonderen", "Gönderen Kişi");
            dataGridView1.Columns.Add("Konu", "Konu Başlığı");
            dataGridView1.Columns.Add("Tarih", "Tarih");

            // Sütun genişliklerini ayarla
            dataGridView1.Columns[0].Width = 150; // Gönderen
            dataGridView1.Columns[1].Width = 250; // Konu (Geniş olsun)

            // SAHTE MESAJLAR EKLE (Sanki veritabanından gelmiş gibi)
            dataGridView1.Rows.Add("İnsan Kaynakları", "Maaş Bordrosu Hk.", "12.12.2025");
            dataGridView1.Rows.Add("Ahmet Şef", "Yarınki vardiya değişimi", "11.12.2025");
            dataGridView1.Rows.Add("Sistem Yöneticisi", "Hoşgeldiniz!", "10.12.2025");
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // 1. KONTROL: Kutular boş mu?
            if (txtAlici.Text == "" || txtKonu.Text == "" || txtMesaj.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur, aşağıya inme.
            }

            // --- BURASI VERİTABANI (SQL) GELİNCE DEĞİŞECEK ---
            // Şimdilik başarılı olmuş gibi yapıyoruz.

            MessageBox.Show("Mesajınız başarıyla iletildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. TEMİZLİK: Kutuları boşalt
            txtAlici.Text = "";
            txtKonu.Text = "";
            txtMesaj.Text = "";

            // 3. YÖNLENDİRME: İş bitince 'Gelen Kutusu' sekmesine (0. index) geri dön
            tabControl1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat, ana menüye dön.
            CalisanEkranı cal = new CalisanEkranı();
            cal.ShowDialog();
        }
    }
}
