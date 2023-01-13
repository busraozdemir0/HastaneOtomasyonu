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
    public partial class frmAdminGiris : Form
    {
        public static int FK;
        public frmAdminGiris()
        {
            InitializeComponent();

        }
        SqlBaglanti baglan = new SqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select AdminID from Admin where AdminKullaniciAd=@ad and AdminSifre=@sifre", baglan.baglanti());
            komut1.Parameters.AddWithValue("@ad", msktxtTc.Text);
            komut1.Parameters.AddWithValue("@sifre", txtSifre.Text);

            SqlDataReader sqlDataReader1 = komut1.ExecuteReader();
            if (sqlDataReader1.Read())
            {
                FK = Convert.ToInt32(sqlDataReader1[0]);

            }
            SqlCommand komut = new SqlCommand("Select * from Admin where AdminKullaniciAd=@ad and AdminSifre=@sifre", baglan.baglanti());
            komut.Parameters.AddWithValue("@ad", msktxtTc.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            if (sqlDataReader.Read())
            {

                frmSekreterEkle fr = new frmSekreterEkle();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglan.baglanti().Close();
        }


    }
}
