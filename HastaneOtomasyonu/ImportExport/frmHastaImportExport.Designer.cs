
namespace HastaneOtomasyonu.ImportExport
{
    partial class frmHastaImportExport
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
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new HastaneOtomasyonu.appData();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblDosyaAd = new System.Windows.Forms.Label();
            this.txtDosyaAd = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbbxSayfa = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.hastaTableAdapter = new HastaneOtomasyonu.appDataTableAdapters.HastaTableAdapter();
            this.hastaneOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgrHasta = new System.Windows.Forms.DataGridView();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDogumTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonDataSet1 = new HastaneOtomasyonu.HastaneOtomasyonDataSet1();
            this.hastaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaTableAdapter1 = new HastaneOtomasyonu.HastaneOtomasyonDataSet1TableAdapters.HastaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "appData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfa.Location = new System.Drawing.Point(90, 304);
            this.lblSayfa.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(103, 47);
            this.lblSayfa.TabIndex = 8;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblDosyaAd
            // 
            this.lblDosyaAd.AutoSize = true;
            this.lblDosyaAd.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAd.Location = new System.Drawing.Point(28, 257);
            this.lblDosyaAd.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblDosyaAd.Name = "lblDosyaAd";
            this.lblDosyaAd.Size = new System.Drawing.Size(165, 47);
            this.lblDosyaAd.TabIndex = 7;
            this.lblDosyaAd.Text = "Dosya Adı:";
            // 
            // txtDosyaAd
            // 
            this.txtDosyaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAd.Location = new System.Drawing.Point(200, 264);
            this.txtDosyaAd.Margin = new System.Windows.Forms.Padding(7);
            this.txtDosyaAd.Name = "txtDosyaAd";
            this.txtDosyaAd.Size = new System.Drawing.Size(456, 35);
            this.txtDosyaAd.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.Location = new System.Drawing.Point(664, 264);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(7);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 35);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbbxSayfa
            // 
            this.cmbbxSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbxSayfa.FormattingEnabled = true;
            this.cmbbxSayfa.Location = new System.Drawing.Point(200, 311);
            this.cmbbxSayfa.Name = "cmbbxSayfa";
            this.cmbbxSayfa.Size = new System.Drawing.Size(185, 37);
            this.cmbbxSayfa.TabIndex = 11;
            this.cmbbxSayfa.SelectedIndexChanged += new System.EventHandler(this.cmbbxSayfa_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnImport.Location = new System.Drawing.Point(404, 306);
            this.btnImport.Margin = new System.Windows.Forms.Padding(7);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(128, 44);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(555, 307);
            this.btnExport.Margin = new System.Windows.Forms.Padding(7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 44);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // dtgrHasta
            // 
            this.dtgrHasta.AllowUserToAddRows = false;
            this.dtgrHasta.AllowUserToDeleteRows = false;
            this.dtgrHasta.AutoGenerateColumns = false;
            this.dtgrHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaIDDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.hastaTelefonDataGridViewTextBoxColumn,
            this.hastaCinsiyetDataGridViewTextBoxColumn,
            this.hastaDogumTarihDataGridViewTextBoxColumn,
            this.sekreterIDDataGridViewTextBoxColumn});
            this.dtgrHasta.DataSource = this.hastaBindingSource2;
            this.dtgrHasta.Location = new System.Drawing.Point(12, 17);
            this.dtgrHasta.Name = "dtgrHasta";
            this.dtgrHasta.ReadOnly = true;
            this.dtgrHasta.Size = new System.Drawing.Size(749, 237);
            this.dtgrHasta.TabIndex = 14;
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            this.hastaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            this.hastaTcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            this.hastaAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            this.hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            this.hastaSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTelefonDataGridViewTextBoxColumn
            // 
            this.hastaTelefonDataGridViewTextBoxColumn.DataPropertyName = "HastaTelefon";
            this.hastaTelefonDataGridViewTextBoxColumn.HeaderText = "HastaTelefon";
            this.hastaTelefonDataGridViewTextBoxColumn.Name = "hastaTelefonDataGridViewTextBoxColumn";
            this.hastaTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaCinsiyetDataGridViewTextBoxColumn
            // 
            this.hastaCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "HastaCinsiyet";
            this.hastaCinsiyetDataGridViewTextBoxColumn.HeaderText = "HastaCinsiyet";
            this.hastaCinsiyetDataGridViewTextBoxColumn.Name = "hastaCinsiyetDataGridViewTextBoxColumn";
            this.hastaCinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaDogumTarihDataGridViewTextBoxColumn
            // 
            this.hastaDogumTarihDataGridViewTextBoxColumn.DataPropertyName = "HastaDogumTarih";
            this.hastaDogumTarihDataGridViewTextBoxColumn.HeaderText = "HastaDogumTarih";
            this.hastaDogumTarihDataGridViewTextBoxColumn.Name = "hastaDogumTarihDataGridViewTextBoxColumn";
            this.hastaDogumTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sekreterIDDataGridViewTextBoxColumn
            // 
            this.sekreterIDDataGridViewTextBoxColumn.DataPropertyName = "SekreterID";
            this.sekreterIDDataGridViewTextBoxColumn.HeaderText = "SekreterID";
            this.sekreterIDDataGridViewTextBoxColumn.Name = "sekreterIDDataGridViewTextBoxColumn";
            this.sekreterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaBindingSource1
            // 
            this.hastaBindingSource1.DataMember = "Hasta";
            this.hastaBindingSource1.DataSource = this.appData;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // hastaneOtomasyonDataSet1
            // 
            this.hastaneOtomasyonDataSet1.DataSetName = "HastaneOtomasyonDataSet1";
            this.hastaneOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBindingSource2
            // 
            this.hastaBindingSource2.DataMember = "Hasta";
            this.hastaBindingSource2.DataSource = this.hastaneOtomasyonDataSet1;
            // 
            // hastaTableAdapter1
            // 
            this.hastaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmHastaImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(760, 382);
            this.Controls.Add(this.dtgrHasta);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cmbbxSayfa);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDosyaAd);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblDosyaAd);
            this.Name = "frmHastaImportExport";
            this.Text = "HASTA IMPORT/EXPORT";
            this.Load += new System.EventHandler(this.frmHastaImportExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblDosyaAd;
        private System.Windows.Forms.TextBox txtDosyaAd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbbxSayfa;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private appData appData;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private appDataTableAdapters.HastaTableAdapter hastaTableAdapter;
        
        private System.Windows.Forms.BindingSource hastaneOtomasyonDataSetBindingSource;
        private System.Windows.Forms.DataGridView dtgrHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDogumTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.BindingSource hastaBindingSource1;
        private HastaneOtomasyonDataSet1 hastaneOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource hastaBindingSource2;
        private HastaneOtomasyonDataSet1TableAdapters.HastaTableAdapter hastaTableAdapter1;
    }
}