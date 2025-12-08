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

    public partial class Form1 : Form
    {
        bool surukleniyorMu = false;
        Point ilkkonum;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyorMu = true;
            ilkkonum = e.Location; // Farenin nerede olduğunu hafızaya al
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyorMu)
            {
                // Formu yeni konuma taşı
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyorMu = false; // Sürükleme bitti
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Adım: Açılacak formdan bir nesne türetiyoruz.
            // Eğer formunun adı 'Form2' ise burayı 'Form2 fr = new Form2();' yap.
            KayitOl fr = new KayitOl();

            // 2. Adım: Mevcut giriş ekranını gizliyoruz (İsteğe bağlı)
            this.Hide();

            // 3. Adım: Yeni formu açıyoruz (ShowDialog, arkadaki forma tıklanmasını engeller)
            fr.ShowDialog();

            // 4. Adım: Kayıt formu kapatılınca Giriş ekranı geri gelsin
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
