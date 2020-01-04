using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu.MusteriIslemleri
{
    public partial class MusteriEkle : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        void YeniKaydet()
        {
            Fonksiyonlar.TBL_Musteriler Musteri = new Fonksiyonlar.TBL_Musteriler();
            Musteri.MusteriAdi = txtAd.Text;
            Musteri.MusteriKullaniciAdi = txtKullaniciAdi.Text;
            Musteri.MusteriMail = txtEmail.Text;
            Musteri.MusteriSifre = txtSifre.Text;
            Musteri.MusteriSoyad = txtSoyad.Text;
            Musteri.MusteriTelefon = txtTelefon.Text;
            DB.TBL_Musterilers.InsertOnSubmit(Musteri);
            DB.SubmitChanges();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
    }
}
