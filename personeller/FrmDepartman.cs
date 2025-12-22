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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            // Veritabanı (SQL) gelince buralar otomatik dolacak.
            // Şimdilik tasarımın dolu gözüksün diye elle yazıyoruz.

            lblAd.Text = "Yazılım Geliştirme & AR-GE";
            lblYonetici.Text = "Ahmet Yılmaz (Kıdemli Mühendis)";
            lblKisiSayisi.Text = "12 Personel";

            txtAciklama.Text = "- Şirket içi otomasyon sistemlerinin geliştirilmesi.\n" +
                               "- Web sitesi ve mobil uygulama bakımları.\n" +
                               "- Siber güvenlik önlemlerinin alınması.\n" +
                               "- Sunucu ve ağ altyapısının yönetimi.";
        }

        // Geri butonu kodunu unutma!
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CalisanEkranı cal = new CalisanEkranı();
            cal.ShowDialog();
        }
    }
}
