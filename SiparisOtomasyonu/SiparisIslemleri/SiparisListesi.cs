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
    public partial class SiparisListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public SiparisListesi()
        {
            InitializeComponent();
        }


        private void SiparisListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.VW_Siparislers
                      where s.MusteriAdi.Contains(txtAdi.Text) && s.MusteriAdi == AnaSayfaMusteri.musteriadi
                      select s;
            dtYoneticiList.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
