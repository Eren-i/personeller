using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace personeller
{
    public partial class MenuKutusu : UserControl
    {
        public MenuKutusu()
        {
            InitializeComponent();
        }

        // --- ÖZELLİKLER ---

        [Category("Ozel Ayarlar")]
        [Browsable(true)]
        public string Baslik
        {
            get { return label1.Text; } // Tasarımdaki label adın label1 olmalı
            set { label1.Text = value; }
        }

        [Category("Ozel Ayarlar")]
        [Browsable(true)]
        public Image Resim
        {
            get { return pictureBox1.Image; } // Tasarımdaki picturebox adın pictureBox1 olmalı
            set { pictureBox1.Image = value; }
        }

        // --- EKSİK OLAN TIKLAMA KODLARI BURADA ---

        private void MenuKutusu_Load(object sender, EventArgs e)
        {
            // Bu kod şu işe yarar: 
            // Kullanıcı resmin üzerine de tıklasa, yazının üzerine de tıklasa
            // program bunu "Kutunun kendisine tıklandı" olarak algılar.

            pictureBox1.Click += (s, ev) => this.OnClick(ev);
            label1.Click += (s, ev) => this.OnClick(ev);
        }
    }
}