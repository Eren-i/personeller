using System;
using System.Drawing;
using System.Windows.Forms;

namespace personeller
{
    public partial class VardiyaKutusu : UserControl
    {
        public VardiyaKutusu()
        {
            InitializeComponent();
        }

        // 1. Gün Adını değiştirmek için özellik
        public string GunAdi
        {
            get { return lblGun.Text; }
            set { lblGun.Text = value; }
        }

        // 2. Tarihi değiştirmek için özellik
        public string Tarih
        {
            get { return lblTarih.Text; }
            set { lblTarih.Text = value; }
        }

        // 3. Saati değiştirmek için özellik
        public string Saat
        {
            get { return lblSaat.Text; }
            set { lblSaat.Text = value; }
        }

        // 4. İzinli mi Çalışıyor mu Rengi Ayarla
        public void DurumAyarla(string durum)
        {
            if (durum == "İZİNLİ" || durum == "TATİL")
            {
                this.BackColor = Color.MistyRose; // İzinliyse hafif kırmızı
                lblSaat.ForeColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.LightGreen; // Çalışıyorsa yeşil
                lblSaat.ForeColor = Color.DarkGreen;
            }
        }
    }
}