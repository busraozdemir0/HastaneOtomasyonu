
namespace HastaneOtomasyonu.Raporlar
{
    partial class frmRaporlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dtgrdAmeliyat = new System.Windows.Forms.DataGridView();
            this.btnAmeliyatpdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandevuRaporla = new System.Windows.Forms.Button();
            this.dtgrdRandevu = new System.Windows.Forms.DataGridView();
            this.btnRandevupdf = new System.Windows.Forms.Button();
            this.appData = new HastaneOtomasyonu.AppData();
            this.ameliyatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ameliyatTableAdapter = new HastaneOtomasyonu.AppDataTableAdapters.AmeliyatTableAdapter();
            this.appData1 = new HastaneOtomasyonu.AppData1();
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevuTableAdapter = new HastaneOtomasyonu.AppData1TableAdapters.RandevuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAmeliyat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRaporla);
            this.groupBox1.Controls.Add(this.dtgrdAmeliyat);
            this.groupBox1.Controls.Add(this.btnAmeliyatpdf);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 289);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ameliyat Bilgi";
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRaporla.Location = new System.Drawing.Point(190, 232);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(150, 41);
            this.btnRaporla.TabIndex = 12;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dtgrdAmeliyat
            // 
            this.dtgrdAmeliyat.AllowUserToAddRows = false;
            this.dtgrdAmeliyat.AllowUserToDeleteRows = false;
            this.dtgrdAmeliyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdAmeliyat.Location = new System.Drawing.Point(6, 35);
            this.dtgrdAmeliyat.Name = "dtgrdAmeliyat";
            this.dtgrdAmeliyat.ReadOnly = true;
            this.dtgrdAmeliyat.Size = new System.Drawing.Size(716, 191);
            this.dtgrdAmeliyat.TabIndex = 17;
            // 
            // btnAmeliyatpdf
            // 
            this.btnAmeliyatpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnAmeliyatpdf.Location = new System.Drawing.Point(366, 232);
            this.btnAmeliyatpdf.Name = "btnAmeliyatpdf";
            this.btnAmeliyatpdf.Size = new System.Drawing.Size(132, 41);
            this.btnAmeliyatpdf.TabIndex = 14;
            this.btnAmeliyatpdf.Text = "PDF";
            this.btnAmeliyatpdf.UseVisualStyleBackColor = false;
            this.btnAmeliyatpdf.Click += new System.EventHandler(this.btnAmeliyatpdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandevuRaporla);
            this.groupBox2.Controls.Add(this.dtgrdRandevu);
            this.groupBox2.Controls.Add(this.btnRandevupdf);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 289);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgi";
            // 
            // btnRandevuRaporla
            // 
            this.btnRandevuRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRandevuRaporla.Location = new System.Drawing.Point(190, 232);
            this.btnRandevuRaporla.Name = "btnRandevuRaporla";
            this.btnRandevuRaporla.Size = new System.Drawing.Size(150, 41);
            this.btnRandevuRaporla.TabIndex = 12;
            this.btnRandevuRaporla.Text = "Raporla";
            this.btnRandevuRaporla.UseVisualStyleBackColor = false;
            this.btnRandevuRaporla.Click += new System.EventHandler(this.btnRandevuRaporla_Click);
            // 
            // dtgrdRandevu
            // 
            this.dtgrdRandevu.AllowUserToAddRows = false;
            this.dtgrdRandevu.AllowUserToDeleteRows = false;
            this.dtgrdRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdRandevu.Location = new System.Drawing.Point(6, 35);
            this.dtgrdRandevu.Name = "dtgrdRandevu";
            this.dtgrdRandevu.ReadOnly = true;
            this.dtgrdRandevu.Size = new System.Drawing.Size(716, 191);
            this.dtgrdRandevu.TabIndex = 17;
            // 
            // btnRandevupdf
            // 
            this.btnRandevupdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRandevupdf.Location = new System.Drawing.Point(366, 232);
            this.btnRandevupdf.Name = "btnRandevupdf";
            this.btnRandevupdf.Size = new System.Drawing.Size(132, 41);
            this.btnRandevupdf.TabIndex = 14;
            this.btnRandevupdf.Text = "PDF";
            this.btnRandevupdf.UseVisualStyleBackColor = false;
            this.btnRandevupdf.Click += new System.EventHandler(this.btnRandevupdf_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ameliyatBindingSource
            // 
            this.ameliyatBindingSource.DataMember = "Ameliyat";
            this.ameliyatBindingSource.DataSource = this.appData;
            // 
            // ameliyatTableAdapter
            // 
            this.ameliyatTableAdapter.ClearBeforeFill = true;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData1";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataMember = "Randevu";
            this.randevuBindingSource.DataSource = this.appData1;
            // 
            // randevuTableAdapter
            // 
            this.randevuTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(755, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRaporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPORLAMA";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAmeliyat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdAmeliyat;
        private System.Windows.Forms.Button btnAmeliyatpdf;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandevuRaporla;
        private System.Windows.Forms.DataGridView dtgrdRandevu;
        private System.Windows.Forms.Button btnRandevupdf;
        private AppData appData;
        private System.Windows.Forms.BindingSource ameliyatBindingSource;
        private AppDataTableAdapters.AmeliyatTableAdapter ameliyatTableAdapter;
        private AppData1 appData1;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private AppData1TableAdapters.RandevuTableAdapter randevuTableAdapter;
    }
}