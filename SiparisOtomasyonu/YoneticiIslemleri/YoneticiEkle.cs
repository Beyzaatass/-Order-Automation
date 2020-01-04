using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class YoneticiEkle : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public YoneticiEkle()
        {
            InitializeComponent();
        }

        private void YoneticiEkle_Load(object sender, EventArgs e)
        {

        }

        void YeniKaydet()
        {
            Fonksiyonlar.TBL_Yoneticiler Yonetici = new Fonksiyonlar.TBL_Yoneticiler();
            Yonetici.YoneticiAdi = txtAd.Text;
            Yonetici.YoneticiSifre = txtSifre.Text;
            Yonetici.YoneticiSoyadi = txtSoyad.Text;
            Yonetici.YoneticiKullaniciAdi = txtKullaniciAdi.Text;
            DB.TBL_Yoneticilers.InsertOnSubmit(Yonetici);
            DB.SubmitChanges();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
            MessageBox.Show("Yeni Yönetici Kaydı Yapılmıştır.");
        }
    }
}
