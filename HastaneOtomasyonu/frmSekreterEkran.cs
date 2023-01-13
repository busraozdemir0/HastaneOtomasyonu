using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class frmSekreterEkran : Form
    {
        public frmSekreterEkran()
        {
            InitializeComponent();
        }

        private void pcbxRandevu_Click(object sender, EventArgs e)
        {
            frmRandevuOlustur frm = new frmRandevuOlustur();
            frm.Show();
        }

        private void pcbxBrans_Click(object sender, EventArgs e)
        {
            frmBransEkle frm = new frmBransEkle();
            frm.Show();

        }

        private void pcbxDoktor_Click(object sender, EventArgs e)
        {
            frmDoktorEkle frm = new frmDoktorEkle();
            frm.Show();
        }

        private void pcbxHasta_Click(object sender, EventArgs e)
        {
            frmHastaEkle frm = new frmHastaEkle();
            frm.Show();
        }

        private void frmSekreterEkran_Load(object sender, EventArgs e)
        {

        }

        private void pcbxAmeliyatRapor_Click(object sender, EventArgs e)
        {
            Raporlar.frmRaporlama frm = new Raporlar.frmRaporlama();
            frm.Show();
        }
    }
}
