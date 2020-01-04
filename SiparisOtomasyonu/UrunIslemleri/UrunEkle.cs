using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu.UrunIslemleri
{
    public partial class UrunEkle : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
        void YeniKaydet()
        {
            Fonksiyonlar.TBL_Urun Urun = new Fonksiyonlar.TBL_Urun();
            Urun.StokAdet = txtStokSayisi.Text;
            Urun.UrunAdi = txtUrunAdi.Text;
            Urun.UrunFiyat = txtFiyat.Text;
            DB.TBL_Uruns.InsertOnSubmit(Urun);
            DB.SubmitChanges();
        }
    }
}
