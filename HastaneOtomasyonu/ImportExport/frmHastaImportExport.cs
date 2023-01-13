using ClosedXML.Excel;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace HastaneOtomasyonu.ImportExport
{
    public partial class frmHastaImportExport : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        SqlDataAdapter sqlDataAdapter;
        DataTable dt = new DataTable();
        public void listele()
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Hasta", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrHasta.DataSource = dt;
        }
        public frmHastaImportExport()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDosyaAd.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbbxSayfa.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cmbbxSayfa.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void cmbbxSayfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbbxSayfa.SelectedItem.ToString()];
            dtgrHasta.DataSource = dt;
            if (dt != null)
            {
                List<Hasta> hastalar = new List<Hasta>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Hasta hasta = new Hasta();
                    hasta.HastaID = dt.Rows[i]["HastaID"].ToString();
                    hasta.HastaTc = dt.Rows[i]["HastaTc"].ToString();
                    hasta.HastaAd = dt.Rows[i]["HastaAd"].ToString();
                    hasta.HastaSoyad = dt.Rows[i]["HastaSoyad"].ToString();
                    hasta.HastaTelefon = dt.Rows[i]["HastaTelefon"].ToString();
                    hasta.HastaCinsiyet = dt.Rows[i]["HastaCinsiyet"].ToString();
                    hasta.HastaDogumTarih = dt.Rows[i]["HastaDogumTarih"].ToString();
                    hasta.SekreterID = dt.Rows[i]["SekreterID"].ToString();
                    hastalar.Add(hasta);

                }
                hastaBindingSource1.DataSource = hastalar;
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.hastaneOtomasyonDataSet1.Hasta.CopyToDataTable(), "Hasta");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("export işlemi başarıyla gerçekleşti.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int satir = dtgrHasta.Rows.Count;
            if (satir > 0)

            {
                String tc, ad, soyad, telefon, cinsiyet, dogumtarih, sekreterid;

                for (int i = 0; i < satir; i++)
                {
                    tc = dtgrHasta.Rows[i].Cells[1].Value.ToString();
                    ad = dtgrHasta.Rows[i].Cells[2].Value.ToString();
                    soyad = dtgrHasta.Rows[i].Cells[3].Value.ToString();
                    telefon = dtgrHasta.Rows[i].Cells[4].Value.ToString();
                    cinsiyet = dtgrHasta.Rows[i].Cells[5].Value.ToString();
                    dogumtarih = dtgrHasta.Rows[i].Cells[6].Value.ToString();
                    sekreterid = dtgrHasta.Rows[i].Cells[7].Value.ToString();

                    SqlCommand komut = new SqlCommand("Insert into Hasta(HastaTc,HastaAd,HastaSoyad,HastaTelefon,HastaCinsiyet,HastaDogumTarih,SekreterID) Values (@tc,@ad,@soyad,@telefon,@cinsiyet,@dogumtarih,@sekreterid)", baglan.baglanti());
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@ad", ad);
                    komut.Parameters.AddWithValue("@soyad", soyad);
                    komut.Parameters.AddWithValue("@telefon", telefon);
                    komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    komut.Parameters.AddWithValue("@dogumtarih", dogumtarih);
                    komut.Parameters.AddWithValue("@sekreterid", sekreterid);
                    komut.ExecuteNonQuery();

                }
                baglan.baglanti().Close();
                MessageBox.Show("İmport işlemi başarıyla gerçekleşti.");
            }
        }

        private void frmHastaImportExport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonDataSet1.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter1.Fill(this.hastaneOtomasyonDataSet1.Hasta);
            listele();
        }
    }
}







