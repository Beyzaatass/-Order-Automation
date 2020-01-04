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
    public partial class SiparisListesiYonetici : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public SiparisListesiYonetici()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.VW_Siparislers
                      where s.MusteriAdi.Contains(txtAdi.Text)
                      select s;
            dtYoneticiList.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void SiparisListesiYonetici_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
