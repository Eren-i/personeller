using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // 1. EKLENDİ: Bu kütüphane şart
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeller
{
    public partial class Form1 : Form
    {
        // 2. EKLENDİ: Windows'un placeholder özelliğini çağıran sihirli kodlar
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Değişkenlerin
        bool surukleniyorMu = false;
        Point ilkkonum;

        public Form1()
        {
            InitializeComponent();
        }

        // 3. EKLENDİ: Form açılırken yazıları yerleştirir
        private void Form1_Load(object sender, EventArgs e)
        {
            // Üstteki Kutu (Kullanıcı Adı)
            SendMessage(txtUserName.Handle, EM_SETCUEBANNER, 0, "SSN / İşyeri Sicil No");

            // Alttaki Kutu (Şifre)
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, 0, "Şifrenizi Giriniz");
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // --- Senin Sürükleme Kodların ---
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyorMu = true;
            ilkkonum = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyorMu)
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyorMu = false;
        }

        // --- Senin Link ve Çıkış Kodların ---
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl fr = new KayitOl();
            this.Hide();
            fr.ShowDialog();
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