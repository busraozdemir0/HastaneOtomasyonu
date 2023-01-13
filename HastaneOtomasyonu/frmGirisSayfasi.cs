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
    public partial class frmGirisPaneli : Form
    {
        public frmGirisPaneli()
        {
            InitializeComponent();
        }

        private void pcrbxAdmin_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void pcrbxSekreter_Click(object sender, EventArgs e)
        {
            frmSekreterGiris fr = new frmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void pcrbxDoktor_Click(object sender, EventArgs e)
        {
            frmDoktorGiris fr = new frmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void pctrbxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblYedekle_Click(object sender, EventArgs e)
        {
            Yedekleme.frmBackUp fr = new Yedekleme.frmBackUp();
            fr.Show();
        }

        private void lblYedektenDon_Click(object sender, EventArgs e)
        {
            Yedekleme.frmRestore fr = new Yedekleme.frmRestore();
            fr.Show();
        }

        private void lblimportExport_Click(object sender, EventArgs e)
        {
            ImportExport.frmHastaImportExport fr = new ImportExport.frmHastaImportExport();
            fr.Show();
            this.Hide();
        }
    }
}
