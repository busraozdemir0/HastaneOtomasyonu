using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class frmDoktorEkle : Form
    {
        public static int bransid;
        SqlBaglanti baglan = new SqlBaglanti();
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Doktor", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdDoktor.DataSource = dt;
        }
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select BransID From Brans where BransAd = @bransad", baglan.baglanti());
            komut1.Parameters.AddWithValue("@bransad", cmbxBrans.Text);
            SqlDataReader sqlDataReader1 = komut1.ExecuteReader();
            if (sqlDataReader1.Read())
            {
                bransid = Convert.ToInt32(sqlDataReader1[0]);

            }

            SqlCommand komut = new SqlCommand("Insert into Doktor(DoktorTc, DoktorAd, DoktorSoyad, DoktorSifre,SekreterID,BransID) Values (@tc,@ad,@soyad,@sifre,@ID,@bransid)", baglan.baglanti());
            komut.Parameters.AddWithValue("@tc", msktxtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@ID", frmSekreterGiris.FK);
            komut.Parameters.AddWithValue("@bransid", bransid);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            listele();
            lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);

            SqlCommand komut = new SqlCommand("select  BransAd from Brans", baglan.baglanti());

            SqlDataReader sqlDataReader = komut.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbxBrans.Items.Add(sqlDataReader[0].ToString());
            }
            baglan.baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand insertKomutu = new SqlCommand( "INSERT INTO dbo.Doktor_Silinenler (DoktorAd,DoktorSifre,DoktorSoyad,DoktorTc, BransID, SekreterID) SELECT DoktorAd,DoktorSifre,DoktorSoyad,DoktorTc,BransID, SekreterID FROM Doktor WHERE DoktorTc=@doktorTC SET IDENTITY_INSERT Doktor_Silinenler OFF;" , baglan.baglanti() );
            insertKomutu.Parameters.AddWithValue( "@doktorTC" , msktxtTC.Text );
            insertKomutu.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Delete from Doktor where DoktorTc=@doktorTC", baglan.baglanti());
            komut.Parameters.AddWithValue("@doktorTC", msktxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
            lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Doktor set DoktorAd=@ad, DoktorSoyad=@soyad, DoktorSifre=@sifre where DoktorTc=@tc", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@tc", msktxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Doktor where DoktorAd like '" + txtAdAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrdDoktor.DataSource = dt;
            baglan.baglanti().Close();
            if (txtAdAra.Text == "")
            {
                listele();
                lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
            }
            else
                lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
        }



        private void dtgrdDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrdDoktor.SelectedCells[0].RowIndex;
            msktxtTC.Text = dtgrdDoktor.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dtgrdDoktor.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dtgrdDoktor.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dtgrdDoktor.Rows[secilen].Cells[4].Value.ToString();
            cmbxBrans.Text = dtgrdDoktor.Rows[secilen].Cells[5].Value.ToString();
        }

        private void txtDoktorTCAra_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Doktor where DoktorTc like '" + txtDoktorTCAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrdDoktor.DataSource = dt;
            baglan.baglanti().Close();
            if (txtDoktorTCAra.Text == "")
            {
                listele();
                lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
            }
            else
                lblToplamDoktor.Text = Convert.ToString(dtgrdDoktor.RowCount - 1);
        }

    }
}
