
namespace HastaneOtomasyonu.Yedekleme
{
    partial class frmBackUp
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
            this.btnYedekle = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYedekle
            // 
            this.btnYedekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnYedekle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.Location = new System.Drawing.Point(244, 153);
            this.btnYedekle.Margin = new System.Windows.Forms.Padding(7);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(198, 51);
            this.btnYedekle.TabIndex = 15;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = false;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDB.Location = new System.Drawing.Point(244, 104);
            this.txtDB.Margin = new System.Windows.Forms.Padding(7);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(198, 41);
            this.txtDB.TabIndex = 14;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(20, 94);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(228, 47);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Veritabanı Adı:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(65, 40);
            this.lblTc.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(183, 47);
            this.lblTc.TabIndex = 11;
            this.lblTc.Text = "Sunucu Adı:";
            // 
            // txtSunucu
            // 
            this.txtSunucu.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSunucu.Location = new System.Drawing.Point(244, 47);
            this.txtSunucu.Margin = new System.Windows.Forms.Padding(7);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(198, 41);
            this.txtSunucu.TabIndex = 16;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(472, 232);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTc);
            this.Name = "frmBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YEDEK ALMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtSunucu;
    }
}