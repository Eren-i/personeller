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
    public partial class mdravans : Form
    {
        public mdravans()
        {
            InitializeComponent();
        }

        private void mdravans_Load(object sender, EventArgs e)
        {
            // Şimdilik test amaçlı manuel ekleyelim. 
            // İleride burayı veritabanından çekeceğiz.
            comboBox1.Items.Add("Ahmet Yılmaz");
            comboBox1.Items.Add("Ayşe Demir");
            comboBox1.Items.Add("Mehmet Can");

            comboBox2.Items.Add("Yazılım");
            comboBox2.Items.Add("Muhasebe");
            comboBox2.Items.Add("İnsan Kaynakları");

            // Varsayılan olarak ilk elemanları seçili getirir
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Hata kontrolü: Personel seçilmemişse durdur
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir personel seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Bilgileri topluyoruz
            string personel = comboBox1.SelectedItem.ToString();
            string departman = comboBox2.SelectedItem.ToString();
            decimal miktar = numericUpDown2.Value; // NumericUpDown ismini kontrol et
            string aciklama = textBox2.Text; // RichTextBox/TextBox ismin

            // Şimdilik sadece onay mesajı gösteriyoruz (Veritabanı bağlantısı henüz yok)
            string mesaj = $"{personel} için {miktar} TL tutarındaki avans başarıyla ONAYLANDI.\nDepartman: {departman}";

            MessageBox.Show(mesaj, "Avans Onay Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bu avans talebini reddetmek ve silmek istediğinize emin misiniz?",
                                        "Talep Reddi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                // Alanları temizle
                numericUpDown2.Value = 0;
                textBox2.Clear();
                MessageBox.Show("Talep reddedildi.");
            }
        }

    }
}
