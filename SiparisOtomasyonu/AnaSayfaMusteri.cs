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
    public partial class AnaSayfaMusteri : Form
    {
        public static Fonksiyonlar.TBL_Musteriler Musteri;
        public static int MusteriID = -1;
        public static int Aktarma = -1;
        public static string musteriadi = "";
        public AnaSayfaMusteri()
        {
            InitializeComponent();
        }

        public AnaSayfaMusteri(Fonksiyonlar.TBL_Musteriler GelenMusteri)
        {
            InitializeComponent();
            Musteri = GelenMusteri;
            MusteriID = Musteri.ID;
            musteriadi = Musteri.MusteriAdi + " " + Musteri.MusteriSoyad;
            lblMusteriAdi.Text = Musteri.MusteriAdi + " " + Musteri.MusteriSoyad;
            
        }

        private void AnaSayfaMusteri_Load(object sender, EventArgs e)
        {

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SiparisIslemleri.SiparisEkle frm = new SiparisIslemleri.SiparisEkle();
            frm.Show();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            SiparisIslemleri.SiparisListesi frm = new SiparisIslemleri.SiparisListesi();
            frm.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunIslemleri.UrunListesi frm = new UrunIslemleri.UrunListesi();
            frm.Show();
        }
    }
}
