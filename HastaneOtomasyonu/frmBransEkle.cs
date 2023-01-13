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
    public partial class frmBransEkle : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Brans", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrBrans.DataSource = dt;
        }
        public frmBransEkle()
        {
            InitializeComponent();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Brans(BransAd) Values (@ad)", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", txtBransAd.Text);
            
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            lblToplamBrans.Text = Convert.ToString(dtgrBrans.RowCount - 1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand insertKomut = new SqlCommand( "INSERT INTO dbo.Brans_Silinenler (BransAd) SELECT BransAd FROM Brans WHERE BransAd=@ad SET " +
                "IDENTITY_INSERT dbo.Brans_Silinenler OFF;" , baglan.baglanti() );
            insertKomut.Parameters.AddWithValue( "@ad" , txtBransAd.Text );
            insertKomut.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Delete from Brans where BransAd=@ad", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", txtBransAd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
            lblToplamBrans.Text = Convert.ToString(dtgrBrans.RowCount - 1);
        }

        private void frmBransEkle_Load(object sender, EventArgs e)
        {
            listele();
            lblToplamBrans.Text = Convert.ToString(dtgrBrans.RowCount - 1);
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Brans set BransAd=@ad where BransID=@id", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", txtBransAd.Text);
            int secilen = dtgrBrans.SelectedCells[0].RowIndex;
            komut.Parameters.AddWithValue("@id",dtgrBrans.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Brans Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Brans where BransAd like '" + txtAdAra.Text + "%'", baglan.baglanti());
            adtr.Fill(dt);
            dtgrBrans.DataSource = dt;
            baglan.baglanti().Close();
            if (txtAdAra.Text == "")
            {
                listele();
                lblToplamBrans.Text = Convert.ToString(dtgrBrans.RowCount-1);
            }
            else
            {
                lblToplamBrans.Text = Convert.ToString(dtgrBrans.RowCount - 1);
            }
        }

        private void dtgrBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrBrans.SelectedCells[0].RowIndex;
            txtBransAd.Text = dtgrBrans.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
