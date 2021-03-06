﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu.YoneticiIslemleri
{
    public partial class YoneticiListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public YoneticiListesi()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_Yoneticilers
                      where s.YoneticiAdi.Contains(txtAdi.Text)
                      select s;
            dtYoneticiList.DataSource = lst;
        }

        private void YoneticiListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
