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

namespace HastaneOtomasyonu.Yedekleme
{
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnDosyaYol_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Browse Text Files";

            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.DefaultExt = "BAK";
            openFileDialog.Filter = "Text files (*.bak)|*.bak";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYol.Text = openFileDialog.FileName;
            }
        }

        private void btnYedektenDon_Click(object sender, EventArgs e)
        {
            string servername = txtSunucu.Text;
            string dbname = txtDB.Text;

            string connectionstr = @"Data Source=" + servername + ";Initial Catalog=" + dbname + ";Integrated Security=True";
            SqlConnection baglan = new SqlConnection(connectionstr);

            baglan.Open();

            string str1 = "USE master;";
            string str2 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            string str3 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + txtDosyaYol.Text + "' WITH REPLACE ";
            SqlCommand cmd1 = new SqlCommand(str1, baglan);
            SqlCommand cmd2 = new SqlCommand(str2, baglan);
            SqlCommand cmd3 = new SqlCommand(str3, baglan);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Veritabanınızı yedekten döndürme işlemi başarıyla gerçekleşti.");

            baglan.Close();
            Application.Exit();
            this.Hide();
        }
    }
}
