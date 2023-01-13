using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-G8IS3SP\\SQLEXPRESS;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
