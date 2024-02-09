using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class KitapEklemeİşlemleri : Form
    {


        public KitapEklemeİşlemleri()
        {
            InitializeComponent();
        }
        KitapManager _kitapManager = new KitapManager(new DAL.Repositories.KitapRepository(new KutuphaneOtomasyonDBContext()));
        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _kitapManager.Create(new Kitap
            {
                BarkodNo = int.Parse(txtBarkodNo.Text),
                KitapAdi = txtKitapAdı.Text,
                YazarAdi = txtYazarAdi.Text,
                Yayinevi = txtYayinevi.Text,
                sayfasayisi = int.Parse(txtSayfaSayisi.Text),
                Turu = comboTuru.Text,
                StokSayisi = int.Parse(txtStokSayisi.Text),
                RafNo = int.Parse(txtRafNo.Text),
                Aciklama = txtAciklama.Text,
            });
            MessageBox.Show("Kitap Eklendi");
        }

        private void KitapEklemeFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
