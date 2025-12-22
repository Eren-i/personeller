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
    public partial class CalisanEkranı : Form
    {
        public CalisanEkranı()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuKutusu4_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusu3_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusuEkibim_Click(object sender, EventArgs e)
        {

        }

        private void menuKutusu2_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusu1_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu5_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu8_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu6_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu9_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu10_Load(object sender, EventArgs e)
        {                     
        }

        private void menuKutusu14_Load(object sender, EventArgs e)
        {
        }

        private void menuKutusu10_Load_1(object sender, EventArgs e)
        {
        }

        private void menuKutusu10_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.ShowDialog();
        }

        private void menuKutusu11_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusu11_MouseClick(object sender, MouseEventArgs e)
        {
            FrmDepartman fr = new FrmDepartman();
            fr.ShowDialog();
        }

        private void menuKutusu17_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusu17_Click(object sender, EventArgs e)
        {
            FrmDuyuru fr = new FrmDuyuru();
            fr.ShowDialog();
        }

        private void menuKutusu16_Click(object sender, EventArgs e)
        {
            FrmAvans fr = new FrmAvans();
            fr.ShowDialog();
        }

        private void menuKutusu12_Load(object sender, EventArgs e)
        {

        }

        private void menuKutusu12_Click(object sender, EventArgs e)
        {
            FrmProfil fr = new FrmProfil();
            fr.ShowDialog();
        }

        private void menuKutusu15_Click(object sender, EventArgs e)
        {
            FrmEkibim fr = new FrmEkibim();
            fr.ShowDialog();
        }

        private void menuKutusu13_Click(object sender, EventArgs e)
        {
            FrmVardiyaa fr = new FrmVardiyaa();
            fr.ShowDialog();
        }

        private void menuKutusu14_Click(object sender, EventArgs e)
        {
            Frmİzin fr = new Frmİzin();
            fr.ShowDialog();
        }
    }
}
