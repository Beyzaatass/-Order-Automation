namespace SiparisOtomasyonu
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.rbtnYonetici = new System.Windows.Forms.RadioButton();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.rbtnMusteri = new System.Windows.Forms.RadioButton();
            this.btnYeniMusteriKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(320, 79);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // rbtnYonetici
            // 
            this.rbtnYonetici.AutoSize = true;
            this.rbtnYonetici.Location = new System.Drawing.Point(251, 131);
            this.rbtnYonetici.Name = "rbtnYonetici";
            this.rbtnYonetici.Size = new System.Drawing.Size(63, 17);
            this.rbtnYonetici.TabIndex = 2;
            this.rbtnYonetici.Text = "Yönetici";
            this.rbtnYonetici.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(251, 187);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(169, 23);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(320, 105);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // rbtnMusteri
            // 
            this.rbtnMusteri.AutoSize = true;
            this.rbtnMusteri.Checked = true;
            this.rbtnMusteri.Location = new System.Drawing.Point(251, 154);
            this.rbtnMusteri.Name = "rbtnMusteri";
            this.rbtnMusteri.Size = new System.Drawing.Size(59, 17);
            this.rbtnMusteri.TabIndex = 2;
            this.rbtnMusteri.TabStop = true;
            this.rbtnMusteri.Text = "Müşteri";
            this.rbtnMusteri.UseVisualStyleBackColor = true;
            // 
            // btnYeniMusteriKayit
            // 
            this.btnYeniMusteriKayit.Location = new System.Drawing.Point(251, 216);
            this.btnYeniMusteriKayit.Name = "btnYeniMusteriKayit";
            this.btnYeniMusteriKayit.Size = new System.Drawing.Size(169, 23);
            this.btnYeniMusteriKayit.TabIndex = 3;
            this.btnYeniMusteriKayit.Text = "Yeni Müşteri Kaydı";
            this.btnYeniMusteriKayit.UseVisualStyleBackColor = true;
            this.btnYeniMusteriKayit.Click += new System.EventHandler(this.btnYeniMusteriKayit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYeniMusteriKayit);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.rbtnMusteri);
            this.Controls.Add(this.rbtnYonetici);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.RadioButton rbtnYonetici;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.RadioButton rbtnMusteri;
        private System.Windows.Forms.Button btnYeniMusteriKayit;
    }
}