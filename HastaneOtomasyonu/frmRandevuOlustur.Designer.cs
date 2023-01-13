
namespace HastaneOtomasyonu
{
    partial class frmRandevuOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevuOlustur));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txthastaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrHasta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msktxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpcRandevuTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbbxDoktor = new System.Windows.Forms.ComboBox();
            this.cmbbxBrans = new System.Windows.Forms.ComboBox();
            this.txtrandevuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgrRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRandevu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 43);
            this.label7.TabIndex = 6;
            this.label7.Text = "Branş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Doktor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 43);
            this.label9.TabIndex = 8;
            this.label9.Text = "Randevu Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 43);
            this.label10.TabIndex = 9;
            this.label10.Text = "Randevu Saat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txthastaid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtgrHasta);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 386);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgisi Seçin";
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(144, 71);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(164, 36);
            this.txtTcAra.TabIndex = 32;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txthastaid
            // 
            this.txthastaid.Enabled = false;
            this.txthastaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txthastaid.Location = new System.Drawing.Point(144, 25);
            this.txthastaid.Name = "txthastaid";
            this.txthastaid.Size = new System.Drawing.Size(48, 35);
            this.txthastaid.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hasta ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hasta TC Ara:";
            // 
            // dtgrHasta
            // 
            this.dtgrHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHasta.Location = new System.Drawing.Point(3, 113);
            this.dtgrHasta.Name = "dtgrHasta";
            this.dtgrHasta.Size = new System.Drawing.Size(420, 267);
            this.dtgrHasta.TabIndex = 0;
            this.dtgrHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHasta_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.msktxtSaat);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.dtpcRandevuTarih);
            this.groupBox2.Controls.Add(this.cmbbxDoktor);
            this.groupBox2.Controls.Add(this.cmbbxBrans);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(447, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 394);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgi";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnSil.Location = new System.Drawing.Point(228, 325);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(209, 53);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Randevu Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // msktxtSaat
            // 
            this.msktxtSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.msktxtSaat.Location = new System.Drawing.Point(228, 230);
            this.msktxtSaat.Mask = "90:00";
            this.msktxtSaat.Name = "msktxtSaat";
            this.msktxtSaat.Size = new System.Drawing.Size(209, 35);
            this.msktxtSaat.TabIndex = 12;
            this.msktxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnEkle.Location = new System.Drawing.Point(228, 271);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(209, 48);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Randevu Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpcRandevuTarih
            // 
            this.dtpcRandevuTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpcRandevuTarih.Location = new System.Drawing.Point(228, 180);
            this.dtpcRandevuTarih.Name = "dtpcRandevuTarih";
            this.dtpcRandevuTarih.Size = new System.Drawing.Size(209, 35);
            this.dtpcRandevuTarih.TabIndex = 12;
            // 
            // cmbbxDoktor
            // 
            this.cmbbxDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbbxDoktor.FormattingEnabled = true;
            this.cmbbxDoktor.Location = new System.Drawing.Point(228, 128);
            this.cmbbxDoktor.Name = "cmbbxDoktor";
            this.cmbbxDoktor.Size = new System.Drawing.Size(209, 37);
            this.cmbbxDoktor.TabIndex = 11;
            // 
            // cmbbxBrans
            // 
            this.cmbbxBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbbxBrans.FormattingEnabled = true;
            this.cmbbxBrans.Location = new System.Drawing.Point(228, 76);
            this.cmbbxBrans.Name = "cmbbxBrans";
            this.cmbbxBrans.Size = new System.Drawing.Size(209, 37);
            this.cmbbxBrans.TabIndex = 10;
            this.cmbbxBrans.SelectedIndexChanged += new System.EventHandler(this.cmbbxBrans_SelectedIndexChanged);
            // 
            // txtrandevuid
            // 
            this.txtrandevuid.Enabled = false;
            this.txtrandevuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtrandevuid.Location = new System.Drawing.Point(132, 35);
            this.txtrandevuid.Name = "txtrandevuid";
            this.txtrandevuid.Size = new System.Drawing.Size(45, 35);
            this.txtrandevuid.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Randevu ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtgrRandevu
            // 
            this.dtgrRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrRandevu.Location = new System.Drawing.Point(12, 76);
            this.dtgrRandevu.Name = "dtgrRandevu";
            this.dtgrRandevu.RowHeadersWidth = 51;
            this.dtgrRandevu.RowTemplate.Height = 24;
            this.dtgrRandevu.Size = new System.Drawing.Size(876, 178);
            this.dtgrRandevu.TabIndex = 14;
            this.dtgrRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrRandevu_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtrandevuid);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtgrRandevu);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(888, 267);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // frmRandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(912, 664);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmRandevuOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RANDEVU OLUŞTUR";
            this.Load += new System.EventHandler(this.frmRandevuOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHasta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrRandevu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox msktxtSaat;
        private System.Windows.Forms.DateTimePicker dtpcRandevuTarih;
        private System.Windows.Forms.ComboBox cmbbxDoktor;
        private System.Windows.Forms.ComboBox cmbbxBrans;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgrRandevu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthastaid;
        private System.Windows.Forms.TextBox txtrandevuid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcAra;
    }
}