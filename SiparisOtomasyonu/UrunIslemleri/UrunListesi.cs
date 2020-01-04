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
    public partial class UrunListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public UrunListesi()
        {
            InitializeComponent();
        }

        private void UrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_Uruns
                      where s.UrunAdi.Contains(txtAdi.Text)
                      select s;
            dtYoneticiList.DataSource = lst;
        }
    }
}
