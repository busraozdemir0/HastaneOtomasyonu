using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HastaneOtomasyonu.Raporlar
{
    public partial class frmRaporlama : Form
    {
        public static int doktorID;
        SqlBaglanti baglan = new SqlBaglanti();
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Ameliyat", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdAmeliyat.DataSource = dt;
        }
        public frmRaporlama()
        {
            InitializeComponent();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
      
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("gosterAmeliyat", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdAmeliyat.DataSource = dt;
        }
        private void btnRandevuRaporla_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("gosterRandevu", baglan.baglanti());
            sqlDataAdapter.Fill(dt);
            dtgrdRandevu.DataSource = dt;
        }

        private void btnRandevupdf_Click(object sender, EventArgs e)
        {
            if (dtgrdRandevu.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "RandevuRapor.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Hata Oluştu. Tekrar Deneyiniz." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgrdRandevu.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtgrdRandevu.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrdRandevu.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("İşlem Başarılı.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız", "Info");
            }
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData1.Randevu' table. You can move, or remove it, as needed.
            this.randevuTableAdapter.Fill(this.appData1.Randevu);
            // TODO: This line of code loads data into the 'appData.Ameliyat' table. You can move, or remove it, as needed.
            this.ameliyatTableAdapter.Fill(this.appData.Ameliyat);

        }

        private void btnAmeliyatpdf_Click(object sender, EventArgs e)
        {
            if (dtgrdAmeliyat.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "AmeliyatRapor.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Hata Oluştu. Tekrar Deneyiniz." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgrdAmeliyat.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtgrdAmeliyat.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrdAmeliyat.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("İşlem Başarılı.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata:" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
