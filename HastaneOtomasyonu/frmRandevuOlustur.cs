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

    public partial class frmRandevuOlustur : Form
    {
        int bransID;
        int DoktorID;
        int hastaID;
        public static string bransisim;
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
        public frmRandevuOlustur()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select BransID from Brans where BransAd = @p1", baglan.baglanti());
            komut1.Parameters.AddWithValue("@p1", cmbbxBrans.Text);
            SqlDataReader sqlDataReader1 = komut1.ExecuteReader();
            if (sqlDataReader1.Read())
            {
                bransID = Convert.ToInt32(sqlDataReader1[0]);

            }

            SqlCommand komut2 = new SqlCommand("Select DoktorID from Doktor where DoktorAd = @p1", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbbxDoktor.Text);
            SqlDataReader sqlDataReader2 = komut2.ExecuteReader();
            if (sqlDataReader2.Read())
            {
                DoktorID = Convert.ToInt32(sqlDataReader2[0]);

            }

            SqlCommand komut = new SqlCommand("Insert into Randevu(RandevuTarih,RandevuSaat,SekreterID,BransID,DoktorID,HastaID) Values (@tarih,@saat,@ID,@id1,@id2,@id3)", baglan.baglanti());
            komut.Parameters.AddWithValue("@tarih", dtpcRandevuTarih.Value);
            komut.Parameters.AddWithValue("@saat", msktxtSaat.Text);
            komut.Parameters.AddWithValue("@ID", frmSekreterGiris.FK);
            komut.Parameters.AddWithValue("@id1", bransID);
            komut.Parameters.AddWithValue("@id2", DoktorID);
            komut.Parameters.AddWithValue("@id3", hastaID);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void frmRandevuOlustur_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("select  BransAd from Brans", baglan.baglanti());

            SqlDataReader sqlDataReader = komut.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbxBrans.Items.Add(sqlDataReader[0].ToString());
            }

            baglan.baglanti().Close();
        }

        private void dtgrRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrRandevu.SelectedCells[0].RowIndex;
            txtrandevuid.Text = dtgrRandevu.Rows[secilen].Cells[0].Value.ToString();
            dtpcRandevuTarih.Text = dtgrRandevu.Rows[secilen].Cells[1].Value.ToString();
            msktxtSaat.Text = dtgrRandevu.Rows[secilen].Cells[2].Value.ToString();
        }

        private void cmbbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbbxDoktor.Items.Clear();

            bransisim = cmbbxBrans.Text;

            SqlCommand komut1 = new SqlCommand("select BransID from Brans where BransAd=@p1", baglan.baglanti());
            komut1.Parameters.AddWithValue("@p1", bransisim);
            SqlDataReader sqlDataReader1 = komut1.ExecuteReader();
            if (sqlDataReader1.Read())
            {
                bransID = Convert.ToInt32(sqlDataReader1[0]);

            }

            SqlCommand komut2 = new SqlCommand("select  DoktorAd,DoktorSoyad from Doktor where BransID =@p10", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p10", bransID);

            SqlDataReader sqlDataReader2 = komut2.ExecuteReader();
            while (sqlDataReader2.Read())
            {

                cmbbxDoktor.Items.Add(sqlDataReader2[0].ToString());

            }

            baglan.baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand insertKomut = new SqlCommand( "INSERT INTO dbo.Randevu_Silinenler (RandevuTarih,RandevuSaat,HastaID, DoktorID, SekreterID,BransID) SELECT RandevuTarih,RandevuSaat,HastaID, DoktorID, SekreterID,BransID FROM Randevu WHERE RandevuID=@randevuid SET IDENTITY_INSERT dbo.Randevu_Silinenler OFF;", baglan.baglanti() );
            insertKomut.Parameters.AddWithValue( "@randevuid" , txtrandevuid.Text );
            insertKomut.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Delete from Randevu where RandevuID=@randevuid", baglan.baglanti());
            komut.Parameters.AddWithValue("@randevuid", txtrandevuid.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
        }


        private void dtgrHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrHasta.SelectedCells[0].RowIndex;
            txthastaid.Text = dtgrHasta.Rows[secilen].Cells[0].Value.ToString();
            hastaID = Convert.ToInt32(txthastaid.Text);
        }


        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Hasta where HastaTc like '" + txtTcAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrHasta.DataSource = dt;
            baglan.baglanti().Close();
            if (txtTcAra.Text == "")
            {
                listele();
            }
        }
    }
}
