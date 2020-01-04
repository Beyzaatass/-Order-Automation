namespace SiparisOtomasyonu
{
    partial class AnaSayfaYonetici
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnSiparisListesi = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.btnYoneticiListesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYoneticiAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(26, 56);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(184, 133);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekle ";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(261, 56);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(184, 133);
            this.btnMusteriListele.TabIndex = 0;
            this.btnMusteriListele.Text = "Müşteri Listesi";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(499, 56);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(184, 133);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle ";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(734, 56);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(184, 133);
            this.btnUrunListele.TabIndex = 0;
            this.btnUrunListele.Text = "Ürün Listesi";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnSiparisListesi
            // 
            this.btnSiparisListesi.Location = new System.Drawing.Point(26, 224);
            this.btnSiparisListesi.Name = "btnSiparisListesi";
            this.btnSiparisListesi.Size = new System.Drawing.Size(184, 133);
            this.btnSiparisListesi.TabIndex = 0;
            this.btnSiparisListesi.Text = "Siparis Listesi";
            this.btnSiparisListesi.UseVisualStyleBackColor = true;
            this.btnSiparisListesi.Click += new System.EventHandler(this.btnSiparisListesi_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Location = new System.Drawing.Point(264, 224);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(184, 133);
            this.btnYoneticiEkle.TabIndex = 0;
            this.btnYoneticiEkle.Text = "Yonetici Ekle ";
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // btnYoneticiListesi
            // 
            this.btnYoneticiListesi.Location = new System.Drawing.Point(499, 224);
            this.btnYoneticiListesi.Name = "btnYoneticiListesi";
            this.btnYoneticiListesi.Size = new System.Drawing.Size(184, 133);
            this.btnYoneticiListesi.TabIndex = 0;
            this.btnYoneticiListesi.Text = "Yönetici Listesi";
            this.btnYoneticiListesi.UseVisualStyleBackColor = true;
            this.btnYoneticiListesi.Click += new System.EventHandler(this.btnYoneticiListesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldin";
            // 
            // lblYoneticiAdi
            // 
            this.lblYoneticiAdi.AutoSize = true;
            this.lblYoneticiAdi.Location = new System.Drawing.Point(459, 25);
            this.lblYoneticiAdi.Name = "lblYoneticiAdi";
            this.lblYoneticiAdi.Size = new System.Drawing.Size(0, 13);
            this.lblYoneticiAdi.TabIndex = 1;
            // 
            // AnaSayfaYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.lblYoneticiAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYoneticiListesi);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.btnUrunListele);
            this.Controls.Add(this.btnSiparisListesi);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnMusteriEkle);
            this.Name = "AnaSayfaYonetici";
            this.Text = "AnaSayfaYonetici";
            this.Load += new System.EventHandler(this.AnaSayfaYonetici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnSiparisListesi;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.Button btnYoneticiListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYoneticiAdi;
    }
}