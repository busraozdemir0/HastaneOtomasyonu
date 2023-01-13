
namespace HastaneOtomasyonu.Yedekleme
{
    partial class frmRestore
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
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.btnYedektenDon = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaYol = new System.Windows.Forms.TextBox();
            this.btnDosyaYol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSunucu
            // 
            this.txtSunucu.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSunucu.Location = new System.Drawing.Point(233, 90);
            this.txtSunucu.Margin = new System.Windows.Forms.Padding(7);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(235, 41);
            this.txtSunucu.TabIndex = 21;
            // 
            // btnYedektenDon
            // 
            this.btnYedektenDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnYedektenDon.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedektenDon.Location = new System.Drawing.Point(248, 202);
            this.btnYedektenDon.Margin = new System.Windows.Forms.Padding(7);
            this.btnYedektenDon.Name = "btnYedektenDon";
            this.btnYedektenDon.Size = new System.Drawing.Size(198, 51);
            this.btnYedektenDon.TabIndex = 20;
            this.btnYedektenDon.Text = "Yedekten Dön";
            this.btnYedektenDon.UseVisualStyleBackColor = false;
            this.btnYedektenDon.Click += new System.EventHandler(this.btnYedektenDon_Click);
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDB.Location = new System.Drawing.Point(233, 147);
            this.txtDB.Margin = new System.Windows.Forms.Padding(7);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(235, 41);
            this.txtDB.TabIndex = 19;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(9, 137);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(228, 47);
            this.lblSifre.TabIndex = 18;
            this.lblSifre.Text = "Veritabanı Adı:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(54, 83);
            this.lblTc.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(183, 47);
            this.lblTc.TabIndex = 17;
            this.lblTc.Text = "Sunucu Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 47);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dosya Yolu:";
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaYol.Location = new System.Drawing.Point(233, 30);
            this.txtDosyaYol.Margin = new System.Windows.Forms.Padding(7);
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.Size = new System.Drawing.Size(235, 41);
            this.txtDosyaYol.TabIndex = 23;
            // 
            // btnDosyaYol
            // 
            this.btnDosyaYol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnDosyaYol.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaYol.Location = new System.Drawing.Point(486, 30);
            this.btnDosyaYol.Margin = new System.Windows.Forms.Padding(7);
            this.btnDosyaYol.Name = "btnDosyaYol";
            this.btnDosyaYol.Size = new System.Drawing.Size(46, 41);
            this.btnDosyaYol.TabIndex = 24;
            this.btnDosyaYol.Text = "...";
            this.btnDosyaYol.UseVisualStyleBackColor = false;
            this.btnDosyaYol.Click += new System.EventHandler(this.btnDosyaYol_Click);
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(548, 267);
            this.Controls.Add(this.btnDosyaYol);
            this.Controls.Add(this.txtDosyaYol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.btnYedektenDon);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTc);
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YEDEKTEN DÖN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.Button btnYedektenDon;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaYol;
        private System.Windows.Forms.Button btnDosyaYol;
    }
}