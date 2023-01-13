
namespace HastaneOtomasyonu
{
    partial class frmDoktorislemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorislemler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txthastaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtilacAd = new System.Windows.Forms.TextBox();
            this.dtpReceteTarih = new System.Windows.Forms.DateTimePicker();
            this.rchtxtTaniBilgi = new System.Windows.Forms.RichTextBox();
            this.chbxilac = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtameliyathastaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAmeliyatOlustur = new System.Windows.Forms.Button();
            this.dtpcAmeliyatTarih = new System.Windows.Forms.DateTimePicker();
            this.rchtxtDetay = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHastaTcAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrHasta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRandevu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrRandevu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            // 
            // dtgrRandevu
            // 
            this.dtgrRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrRandevu.Location = new System.Drawing.Point(3, 32);
            this.dtgrRandevu.Name = "dtgrRandevu";
            this.dtgrRandevu.RowHeadersWidth = 51;
            this.dtgrRandevu.RowTemplate.Height = 24;
            this.dtgrRandevu.Size = new System.Drawing.Size(472, 282);
            this.dtgrRandevu.TabIndex = 1;
            this.dtgrRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrRandevu_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txthastaid);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnOlustur);
            this.groupBox3.Controls.Add(this.txtilacAd);
            this.groupBox3.Controls.Add(this.dtpReceteTarih);
            this.groupBox3.Controls.Add(this.rchtxtTaniBilgi);
            this.groupBox3.Controls.Add(this.chbxilac);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(490, -4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 366);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tanı ve Reçete";
            // 
            // txthastaid
            // 
            this.txthastaid.Enabled = false;
            this.txthastaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txthastaid.Location = new System.Drawing.Point(160, 52);
            this.txthastaid.Name = "txthastaid";
            this.txthastaid.Size = new System.Drawing.Size(206, 35);
            this.txthastaid.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hasta ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnOlustur.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.btnOlustur.Location = new System.Drawing.Point(160, 296);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(206, 56);
            this.btnOlustur.TabIndex = 27;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtilacAd
            // 
            this.txtilacAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtilacAd.Location = new System.Drawing.Point(160, 221);
            this.txtilacAd.Name = "txtilacAd";
            this.txtilacAd.Size = new System.Drawing.Size(206, 35);
            this.txtilacAd.TabIndex = 26;
            // 
            // dtpReceteTarih
            // 
            this.dtpReceteTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpReceteTarih.Location = new System.Drawing.Point(160, 95);
            this.dtpReceteTarih.Name = "dtpReceteTarih";
            this.dtpReceteTarih.Size = new System.Drawing.Size(206, 35);
            this.dtpReceteTarih.TabIndex = 25;
            // 
            // rchtxtTaniBilgi
            // 
            this.rchtxtTaniBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rchtxtTaniBilgi.Location = new System.Drawing.Point(160, 140);
            this.rchtxtTaniBilgi.Name = "rchtxtTaniBilgi";
            this.rchtxtTaniBilgi.Size = new System.Drawing.Size(206, 71);
            this.rchtxtTaniBilgi.TabIndex = 4;
            this.rchtxtTaniBilgi.Text = "";
            // 
            // chbxilac
            // 
            this.chbxilac.AutoSize = true;
            this.chbxilac.Location = new System.Drawing.Point(160, 256);
            this.chbxilac.Name = "chbxilac";
            this.chbxilac.Size = new System.Drawing.Size(133, 47);
            this.chbxilac.TabIndex = 3;
            this.chbxilac.Text = "İlaç Yok";
            this.chbxilac.UseVisualStyleBackColor = true;
            this.chbxilac.CheckedChanged += new System.EventHandler(this.chbxilac_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 43);
            this.label9.TabIndex = 2;
            this.label9.Text = "İlaç Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 43);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 43);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tanı Bilgi:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtameliyathastaid);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.btnAmeliyatOlustur);
            this.groupBox4.Controls.Add(this.dtpcAmeliyatTarih);
            this.groupBox4.Controls.Add(this.rchtxtDetay);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(487, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 317);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ameliyat";
            // 
            // txtameliyathastaid
            // 
            this.txtameliyathastaid.Enabled = false;
            this.txtameliyathastaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtameliyathastaid.Location = new System.Drawing.Point(157, 62);
            this.txtameliyathastaid.Name = "txtameliyathastaid";
            this.txtameliyathastaid.Size = new System.Drawing.Size(206, 35);
            this.txtameliyathastaid.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 43);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hasta ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnAmeliyatOlustur
            // 
            this.btnAmeliyatOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnAmeliyatOlustur.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.btnAmeliyatOlustur.Location = new System.Drawing.Point(157, 265);
            this.btnAmeliyatOlustur.Name = "btnAmeliyatOlustur";
            this.btnAmeliyatOlustur.Size = new System.Drawing.Size(206, 49);
            this.btnAmeliyatOlustur.TabIndex = 28;
            this.btnAmeliyatOlustur.Text = "Oluştur";
            this.btnAmeliyatOlustur.UseVisualStyleBackColor = false;
            this.btnAmeliyatOlustur.Click += new System.EventHandler(this.btnAmeliyatOlustur_Click);
            // 
            // dtpcAmeliyatTarih
            // 
            this.dtpcAmeliyatTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpcAmeliyatTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpcAmeliyatTarih.Location = new System.Drawing.Point(157, 103);
            this.dtpcAmeliyatTarih.Name = "dtpcAmeliyatTarih";
            this.dtpcAmeliyatTarih.Size = new System.Drawing.Size(206, 35);
            this.dtpcAmeliyatTarih.TabIndex = 25;
            // 
            // rchtxtDetay
            // 
            this.rchtxtDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rchtxtDetay.Location = new System.Drawing.Point(157, 148);
            this.rchtxtDetay.Name = "rchtxtDetay";
            this.rchtxtDetay.Size = new System.Drawing.Size(206, 111);
            this.rchtxtDetay.TabIndex = 4;
            this.rchtxtDetay.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 43);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tarih:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 43);
            this.label12.TabIndex = 0;
            this.label12.Text = "Detay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHastaTcAra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtgrHasta);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 353);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgisi Seçin";
            // 
            // txtHastaTcAra
            // 
            this.txtHastaTcAra.Location = new System.Drawing.Point(206, 48);
            this.txtHastaTcAra.Name = "txtHastaTcAra";
            this.txtHastaTcAra.Size = new System.Drawing.Size(176, 36);
            this.txtHastaTcAra.TabIndex = 26;
            this.txtHastaTcAra.TextChanged += new System.EventHandler(this.txtHastaTcAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hasta TC Ara:";
            // 
            // dtgrHasta
            // 
            this.dtgrHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHasta.Location = new System.Drawing.Point(6, 98);
            this.dtgrHasta.Name = "dtgrHasta";
            this.dtgrHasta.Size = new System.Drawing.Size(460, 246);
            this.dtgrHasta.TabIndex = 0;
            this.dtgrHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHasta_CellClick);
            // 
            // frmDoktorislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(933, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmDoktorislemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTOR İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmDoktorislemler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRandevu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrRandevu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtilacAd;
        private System.Windows.Forms.DateTimePicker dtpReceteTarih;
        private System.Windows.Forms.RichTextBox rchtxtTaniBilgi;
        private System.Windows.Forms.CheckBox chbxilac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAmeliyatOlustur;
        private System.Windows.Forms.DateTimePicker dtpcAmeliyatTarih;
        private System.Windows.Forms.RichTextBox rchtxtDetay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txthastaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtameliyathastaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaTcAra;
    }
}