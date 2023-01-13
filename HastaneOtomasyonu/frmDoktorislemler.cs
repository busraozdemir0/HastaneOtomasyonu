using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class frmDoktorislemler : Form
    {

        SqlBaglanti baglan = new SqlBaglanti();
        public void listele()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Randevu", baglan.baglanti());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select * from Hasta", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            sqlDataAdapter1.Fill(dt1);
            dtgrRandevu.DataSource = dt;
            dtgrHasta.DataSource = dt1;
        }
        public frmDoktorislemler()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tani(TaniTarih,TaniBilgi,HastaID,DoktorID) Values (@tarih,@bilgi,@id,@id1)", baglan.baglanti());

            komut.Parameters.AddWithValue("@tarih", dtpReceteTarih.Value);
            komut.Parameters.AddWithValue("@bilgi", rchtxtTaniBilgi.Text);
            komut.Parameters.AddWithValue("@id", txthastaid.Text);
            komut.Parameters.AddWithValue("@id1", frmDoktorGiris.FK);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Insert into Recete(IlacAd,HastaID,DoktorID)Values (@ilac,@hastaid,@doktorid)", baglan.baglanti());
            komut2.Parameters.AddWithValue("@ilac", txtilacAd.Text);
            komut2.Parameters.AddWithValue("@hastaid", txthastaid.Text);
            komut2.Parameters.AddWithValue("@doktorid", frmDoktorGiris.FK);
            komut2.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Tani Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void frmDoktorislemler_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void chbxilac_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxilac.Checked)
            {
                txtilacAd.Enabled = false;
            }
            else
            {
                txtilacAd.Enabled = true;
            }
        }

        private void btnAmeliyatOlustur_Click(object sender, EventArgs e)
        {

           
            SqlCommand komut = new SqlCommand("Insert into Ameliyat(AmeliyatDetay,AmeliyatTarih,DoktorID,HastaID,BransID) Values (@detay,@tarih,@id,@id1,@id2)", baglan.baglanti());
            komut.Parameters.AddWithValue("@tarih", dtpcAmeliyatTarih.Value);
            komut.Parameters.AddWithValue("@detay", rchtxtDetay.Text);
            komut.Parameters.AddWithValue("@id1", txtameliyathastaid.Text);
            komut.Parameters.AddWithValue("@id", frmDoktorGiris.FK);
            komut.Parameters.AddWithValue("@id2", frmDoktorGiris.doktorBransFK);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Ameliyat Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dtgrRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrRandevu.SelectedCells[0].RowIndex;
            txtameliyathastaid.Text = dtgrRandevu.Rows[secilen].Cells[3].Value.ToString();
        }

    

        private void dtgrHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrHasta.SelectedCells[0].RowIndex;
            txthastaid.Text = dtgrHasta.Rows[secilen].Cells[0].Value.ToString();
        }

        private void txtHastaTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Hasta where HastaTc like '" + txtHastaTcAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrHasta.DataSource = dt;
            baglan.baglanti().Close();
            if (txtHastaTcAra.Text == "")
            {
                listele();
            }
        }
    }
}
