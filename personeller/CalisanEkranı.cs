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
            FrmProfil fr = new FrmProfil();
            fr.Show();
        }
    }
}
