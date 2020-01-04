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
    public partial class AnaSayfaYonetici : Form
    {
        public static Fonksiyonlar.TBL_Yoneticiler Yonetici;
        public static int YoneticiID = -1;
        public static int AktarmaYonetici = -1;

        public AnaSayfaYonetici()
        {
            InitializeComponent();
        }

        public AnaSayfaYonetici(Fonksiyonlar.TBL_Yoneticiler GelenYonetici)
        {
            InitializeComponent();
            Yonetici = GelenYonetici;
            YoneticiID = Yonetici.ID;
            lblYoneticiAdi.Text = Yonetici.YoneticiAdi + " " + Yonetici.YoneticiSoyadi;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriIslemleri.MusteriEkle frm = new MusteriIslemleri.MusteriEkle();
            frm.Show();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            YoneticiEkle yoneticiEkle = new YoneticiEkle();
            yoneticiEkle.Show();
        }

        private void btnYoneticiListesi_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri.YoneticiListesi yoneticiListesi = new YoneticiIslemleri.YoneticiListesi();
            yoneticiListesi.Show();
        }

        private void AnaSayfaYonetici_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriIslemleri.MusteriListesi frm = new MusteriIslemleri.MusteriListesi();
            frm.Show();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunIslemleri.UrunEkle frm = new UrunIslemleri.UrunEkle();
            frm.Show();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            UrunIslemleri.UrunListesi frm = new UrunIslemleri.UrunListesi();
            frm.Show();
        }

        private void btnSiparisListesi_Click(object sender, EventArgs e)
        {
            SiparisIslemleri.SiparisListesiYonetici frm = new SiparisIslemleri.SiparisListesiYonetici();
            frm.Show();
        }
    }
}
