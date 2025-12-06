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
    public partial class KayitOl : Form
    {
        bool surukleniyorMu = false;
        Point ilkkonum;
        public KayitOl()
        {
            InitializeComponent();
        }

        private void txtEmailName_Enter(object sender, EventArgs e)
        {
            // Eğer kutuda "placeholder" yazısı varsa, onu temizle ve rengi siyah yap
            if (txtEmailName.Text == "E-posta veya Telefon Giriniz")
            {
                txtEmailName.Text = "";
                txtEmailName.ForeColor = Color.Black;
            }
        }

        private void txtEmailName_Leave(object sender, EventArgs e)
        {
            // Eğer kullanıcı bir şey yazmadan çıktıysa, placeholder'ı geri getir
            if (txtEmailName.Text == "")
            {
                txtEmailName.Text = "E-posta veya Telefon Giriniz";
                txtEmailName.ForeColor = Color.Silver;
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TurnBackButton_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void TurnBackButton_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TurnBackButton_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void KayitOl_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyorMu = true;
            ilkkonum = e.Location; // Farenin nerede olduğunu hafızaya al
        }

        private void KayitOl_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyorMu)
            {
                // Formu yeni konuma taşı
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void KayitOl_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyorMu = true;
            ilkkonum = e.Location; // Farenin nerede olduğunu hafızaya al
        }
    }
}
