using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu.SiparisIslemleri
{
    public partial class SiparisEkle : Form
    {
        string OdemeTuru = "";
        Fonksiyonlar.DatabaseDataContext DB;
        public SiparisEkle()
        {
            InitializeComponent();
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            DB = new Fonksiyonlar.DatabaseDataContext();
            cboxUrunler.ValueMember = "ID";
            cboxUrunler.DisplayMember = "UrunAdi";
            cboxUrunler.AccessibleName = "UrunFiyat";
            cboxUrunler.DataSource = DB.TBL_Uruns.ToList();
        }

        

        private void cboxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxUrunler.SelectedIndex!=-1)
            {
                var urunfiyat = (from s in DB.TBL_Uruns
                                 where s.ID == int.Parse(cboxUrunler.SelectedValue.ToString())
                                 select s);
                cboxUrunFiyat.ValueMember = "ID";
                cboxUrunFiyat.DisplayMember = "UrunFiyat";
                cboxUrunFiyat.DataSource = urunfiyat;
            }
        }

        private void txtStokSayisi_TextChanged(object sender, EventArgs e)
        {
            txtToplamFiyat.Text = Convert.ToString(int.Parse(txtStokSayisi.Text) * int.Parse(cboxUrunFiyat.Text.ToString()));
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            panelOdemeYontemi.Visible = true;
            lblToplamFiyat.Text = txtToplamFiyat.Text;
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            panelkredikarti.Visible = false;
            panelKapidaOdeme.Visible = false;
            panelHavale.Visible = true;
            
        }

        private void btnHavaleDevamEt_Click(object sender, EventArgs e)
        {
            panelkredikarti.Visible = false;
            panelHavale.Visible = false;
            panelKapidaOdeme.Visible = true;
            OdemeTuru = "Havale";
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            panelHavale.Visible = false;
            panelKapidaOdeme.Visible = false;
            panelkredikarti.Visible = true;

        }

        private void btnKrediKDevamEt_Click(object sender, EventArgs e)
        {
            panelHavale.Visible = false;
            panelkredikarti.Visible = false;
            panelKapidaOdeme.Visible = true;
            OdemeTuru="Kredi Kartı"
        }

        private void btnKapidaOdeme_Click(object sender, EventArgs e)
        {
            panelkredikarti.Visible = false;
            panelHavale.Visible = false;
            panelKapidaOdeme.Visible = true;
            if(OdemeTuru=="")
            {
                OdemeTuru = "Kapıda Ödeme";
            }
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        void YeniKaydet()
        {
            DB = new Fonksiyonlar.DatabaseDataContext();
            Fonksiyonlar.TBL_Siparisler Siparis = new Fonksiyonlar.TBL_Siparisler();
            Siparis.Adres = txtAdres.Text;
            Siparis.Il = txtIl.Text;
            Siparis.Ilce = txtIlce.Text;
            Siparis.MusteriID = AnaSayfaMusteri.MusteriID;
            Siparis.OdemeTipi = OdemeTuru;
            Siparis.UrunID = int.Parse(cboxUrunler.SelectedValue.ToString());
            Siparis.ToplamUcret = txtToplamFiyat.Text;
            Siparis.Adet = txtStokSayisi.Text;
            DB.TBL_Siparislers.InsertOnSubmit(Siparis);
            DB.SubmitChanges();
        }
    }
}
