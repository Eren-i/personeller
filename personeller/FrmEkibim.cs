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
    public partial class FrmEkibim : Form
    {
        public FrmEkibim()
        {
            InitializeComponent();
        }

        private void FrmEkibim_Load(object sender, EventArgs e)
        {
            // 1. Sütunları Oluştur (Başlıklar)
            dataGridView1.Columns.Add("AdSoyad", "Adı Soyadı");
            dataGridView1.Columns.Add("Gorev", "Görevi / Ünvanı");
            dataGridView1.Columns.Add("Dahili", "Dahili No");
            dataGridView1.Columns.Add("Mail", "E-Posta Adresi");

            // 2. Sütun Genişliklerini Ayarla (Göz kararı)
            dataGridView1.Columns[0].Width = 150; // Ad Soyad
            dataGridView1.Columns[1].Width = 150; // Görev
            dataGridView1.Columns[2].Width = 80;  // Dahili
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Mail kalan yeri kaplasın

            // 3. Sahte Verileri Ekle (Mock Data)
            dataGridView1.Rows.Add("Ahmet Yılmaz", "Takım Lideri", "101", "ahmet@sirket.com");
            dataGridView1.Rows.Add("Ayşe Demir", "Kıdemli Yazılımcı", "102", "ayse@sirket.com");
            dataGridView1.Rows.Add("Mehmet Öztürk", "Yazılım Uzmanı", "103", "mehmet@sirket.com");
            dataGridView1.Rows.Add("Zeynep Kaya", "İş Analisti", "104", "zeynep@sirket.com");
            dataGridView1.Rows.Add("Caner Vural", "Stajyer", "105", "caner@sirket.com");

            // Satır yüksekliğini biraz artıralım, ferah dursun
            dataGridView1.RowTemplate.Height = 30;

            // ... (Üstte senin veri ekleme kodların kalsın) ...

            // 1. GENEL GÖRÜNÜM AYARLARI
            dataGridView1.EnableHeadersVisualStyles = false; // Başlık rengini değiştirebilmek için bu şart!
            dataGridView1.BorderStyle = BorderStyle.None; // Dış çerçeveyi kaldır
            dataGridView1.BackgroundColor = Color.White; // Arka plan bembeyaz olsun
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Sadece yatay çizgiler olsun (Modern görünüm)
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Başlık çizgilerini kaldır

            // 2. BAŞLIK TASARIMI (Üst Kısım)
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Koyu Lacivert (veya SteelBlue yapabilirsin)
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Yazılar Beyaz
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Font: Segoe UI, Kalın
            dataGridView1.ColumnHeadersHeight = 40; // Başlık yüksekliği

            // 3. SATIR TASARIMI (İçerik)
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 251); // Seçilince çok açık gri/mavi olsun (Gözü yormaz)
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black; // Seçilince yazı siyah kalsın
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9); // Satır fontu
            dataGridView1.RowTemplate.Height = 35; // Satırlar ferah olsun (Padding)

            // 4. ZEBRA EFEKTİ (Okumayı kolaylaştırır)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke; // Bir satır beyaz, bir satır açık gri
        }

        // Geri Butonunu Unutma
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
