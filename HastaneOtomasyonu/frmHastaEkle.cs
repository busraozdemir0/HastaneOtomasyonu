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
    public partial class frmHastaEkle : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        int toplamKadinSayisi = 0, toplamErkekSayisi = 0;
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Hasta", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdHastaAra.DataSource = dt;
        }
        public frmHastaEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Insert into Hasta(HastaTc, HastaAd, HastaSoyad, HastaTelefon, HastaCinsiyet,HastaDogumTarih,SekreterID) Values (@tc,@ad,@soyad,@telefon, @cinsiyet,@dogumtarih,@ID)", baglan.baglanti());
            komut.Parameters.AddWithValue("@tc", msktxtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", msktxtTelefon.Text);
            komut.Parameters.AddWithValue("@ID", frmSekreterGiris.FK);
            if (rdbtnE.Checked)
            {
                komut.Parameters.AddWithValue("@cinsiyet", "Erkek");
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", "Kadın");
            }
            komut.Parameters.AddWithValue("@dogumtarih", dtpcDogumTarih.Value);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Hasta Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            SqlCommand cmdKadin = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Kadın' ", baglan.baglanti());
            SqlCommand cmdErkek = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Erkek' ", baglan.baglanti());
            toplamKadinSayisi = Convert.ToInt32(cmdKadin.ExecuteScalar());
            toplamErkekSayisi = Convert.ToInt32(cmdErkek.ExecuteScalar());
            lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
            lblToplamKadin.Text = toplamKadinSayisi.ToString();
            lblToplamErkek.Text = toplamErkekSayisi.ToString();
        }
       
        private void frmHastaEkle_Load_1(object sender, EventArgs e)
        {
            listele();
            SqlCommand cmdKadin = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Kadın' ", baglan.baglanti());
            SqlCommand cmdErkek = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Erkek' ", baglan.baglanti());
            toplamKadinSayisi= Convert.ToInt32(cmdKadin.ExecuteScalar());
            toplamErkekSayisi= Convert.ToInt32(cmdErkek.ExecuteScalar());            
            lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
            lblToplamKadin.Text = toplamKadinSayisi.ToString();
            lblToplamErkek.Text = toplamErkekSayisi.ToString();        
        }

        private void pctrbxİptal_Click(object sender, EventArgs e)
        {
            msktxtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            msktxtTelefon.Text = "";
            rdbtnE.Checked = false;
            rdbtnK.Checked = false;
        }

        private void dtgrdHastaAra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrdHastaAra.SelectedCells[0].RowIndex;
            msktxtTC.Text = dtgrdHastaAra.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dtgrdHastaAra.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dtgrdHastaAra.Rows[secilen].Cells[3].Value.ToString();
            msktxtTelefon.Text = dtgrdHastaAra.Rows[secilen].Cells[4].Value.ToString();
            dtpcDogumTarih.Text = dtgrdHastaAra.Rows[secilen].Cells[6].Value.ToString();
            if(dtgrdHastaAra.Rows[secilen].Cells[5].Value.ToString()=="Erkek")
            {
                rdbtnE.Checked = true;
            }
            else
            {
                rdbtnK.Checked = true;
            }
        }

 
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand insertKomutu = new SqlCommand("INSERT INTO dbo.Hasta_Silinenler (HastaTc,HastaAd,HastaSoyad,HastaTelefon, HastaCinsiyet, HastaDogumTarih, SekreterID) SELECT HastaTc,HastaAd,HastaSoyad,HastaTelefon, HastaCinsiyet, HastaDogumTarih, SekreterID FROM Hasta WHERE HastaTc=@hastaTC SET IDENTITY_INSERT Hasta_Silinenler OFF;", baglan.baglanti());
            insertKomutu.Parameters.AddWithValue("@hastaTC", msktxtTC.Text);
            insertKomutu.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Delete from Hasta where HastaTc=@hastaTC", baglan.baglanti());
            komut.Parameters.AddWithValue("@hastaTC", msktxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
            msktxtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            msktxtTelefon.Text = "";
            rdbtnE.Checked = false;
            rdbtnK.Checked = false;

            SqlCommand cmdKadin = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Kadın' ", baglan.baglanti());
            SqlCommand cmdErkek = new SqlCommand("Select Count(*) from Hasta where HastaCinsiyet='Erkek' ", baglan.baglanti());
            toplamKadinSayisi = Convert.ToInt32(cmdKadin.ExecuteScalar());
            toplamErkekSayisi = Convert.ToInt32(cmdErkek.ExecuteScalar());
            lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
            lblToplamKadin.Text = toplamKadinSayisi.ToString();
            lblToplamErkek.Text = toplamErkekSayisi.ToString();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Hasta where HastaTc like '" + txtTcAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrdHastaAra.DataSource = dt;
            baglan.baglanti().Close();
            if (txtTcAra.Text == "")
            {
                listele();
                lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
            }
            else
                lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
        }

        private void txtTelAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Hasta where HastaTelefon like '" + txtTelAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrdHastaAra.DataSource = dt;
            baglan.baglanti().Close();
            if (txtTelAra.Text == "")
            {
                listele();
                lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
            }
            else
                lblToplamHasta.Text = Convert.ToString(dtgrdHastaAra.RowCount - 1);
        }
    }
}
