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
    public partial class LoginForm : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public LoginForm()
        {
            InitializeComponent();
            txtKullaniciAdi.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (rbtnMusteri.Checked)
            {
                try
                {
                    Fonksiyonlar.TBL_Musteriler Musteri = DB.TBL_Musterilers.First(s => s.MusteriKullaniciAdi == txtKullaniciAdi.Text.Trim() && s.MusteriSifre == txtSifre.Text.Trim());
                    this.Hide();
                    AnaSayfaMusteri frm = new AnaSayfaMusteri(Musteri);
                    frm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı yada şifre hatası");
                    return;
                }
            }
            if (rbtnYonetici.Checked)
            {
                try
                {
                    Fonksiyonlar.TBL_Yoneticiler Yonetici = DB.TBL_Yoneticilers.First(s => s.YoneticiKullaniciAdi == txtKullaniciAdi.Text.Trim() && s.YoneticiSifre == txtSifre.Text.Trim());
                    this.Hide();
                    AnaSayfaYonetici frm = new AnaSayfaYonetici(Yonetici);
                    frm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı yada şifre hatası");
                    return;
                }
            }
        }

        private void btnYeniMusteriKayit_Click(object sender, EventArgs e)
        {
            MusteriIslemleri.MusteriEkle frm = new MusteriIslemleri.MusteriEkle();
            frm.Show();
        }
    }
}
