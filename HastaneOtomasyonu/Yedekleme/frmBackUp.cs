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
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            string serverName = txtSunucu.Text;
            string dbName = txtDB.Text;
            string connectionstr = @"Data Source=" + serverName + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            SqlConnection baglan = new SqlConnection(connectionstr);
            baglan.Open();

            string str1 = "USE " + dbName + ";";
            string str2 = "BACKUP DATABASE " + dbName +
                " TO DISK = 'C:\\database\\" + dbName +
                ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of " + dbName + "';";
            SqlCommand cmd1 = new SqlCommand(str1, baglan);
            SqlCommand cmd2 = new SqlCommand(str2, baglan);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti. Yedeklenen dosyaya ulaşmak için (DB ismi.Bak) uzantısını Disk C:\\database\\(DB ismi.Bak) yolunda bulabilirsiniz.");
            baglan.Close();
        }
    }
}
