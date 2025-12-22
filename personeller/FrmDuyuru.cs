using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeller
{
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }

        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            // Listeyi Temizle
            dataGridView1.Rows.Clear();

            // SAHTE VERİLERİ EKLE (Burası eksik olduğu için liste boş)
            dataGridView1.Rows.Add("Yıllık İzinler Hakkında", "12.12.2025");
            dataGridView1.Rows.Add("Yemekhane Menüsü", "11.12.2025");
            dataGridView1.Rows.Add("Otopark Bakımı", "10.12.2025");
            dataGridView1.Rows.Add("Maaş Zammı Açıklaması", "09.12.2025");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlığa tıklarsa hata vermesin
            if (e.RowIndex < 0) return;

            // Seçilen satırdaki verileri al
            string konu = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tarih = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            // Sağ tarafa yaz
            lblBaslik.Text = konu; // Senin resimde label1 yazan yer
                                   // lblTarih.Text = tarih; // Tarih label'ının adı neyse o
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CalisanEkranı cal = new CalisanEkranı();
            cal.ShowDialog();
        }
    }
}
