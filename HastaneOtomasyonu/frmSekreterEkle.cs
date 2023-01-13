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
    public partial class frmSekreterEkle : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Sekreter", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdSekreter.DataSource = dt;
        }
        public frmSekreterEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Sekreter(SekreterAd, SekreterSoyad, SekreterTc, SekreterSifre,AdminID) Values (@ad,@soyad,@tc,@sifre,@ID)", baglan.baglanti());
            komut.Parameters.AddWithValue("@tc", msktxtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@ID", frmAdminGiris.FK);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Sekreter Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dtgrdSekreter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrdSekreter.SelectedCells[0].RowIndex;
            msktxtTC.Text = dtgrdSekreter.Rows[secilen].Cells[3].Value.ToString();
            txtAd.Text = dtgrdSekreter.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dtgrdSekreter.Rows[secilen].Cells[2].Value.ToString();
            txtSifre.Text = dtgrdSekreter.Rows[secilen].Cells[4].Value.ToString();
        }

        private void frmSekreterEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand insertKomut = new SqlCommand( "INSERT INTO dbo.Sekreter_Silinenler (SekreterAd,SekreterSoyad,SekreterTc,SekreterSifre, AdminID) SELECT SekreterAd,SekreterSoyad,SekreterTc,SekreterSifre, AdminID FROM Sekreter WHERE SekreterTc=@sekreterTC SET IDENTITY_INSERT dbo.Sekreter_Silinenler OFF;" , baglan.baglanti() );
            insertKomut.Parameters.AddWithValue( "@sekreterTC" , msktxtTC.Text );
            insertKomut.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Delete from Sekreter where SekreterTc=@sekreterTC", baglan.baglanti());
            komut.Parameters.AddWithValue("@sekreterTC", msktxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Sekreter set SekreterAd=@ad, SekreterSoyad=@soyad, SekreterSifre=@sifre where SekreterTc=@tc", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@tc", msktxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Sekreter Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

    }
}
