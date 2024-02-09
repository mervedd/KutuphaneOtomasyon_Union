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
    public partial class KitapListelemeİşlemleri : Form
    {
        public KitapListelemeİşlemleri()
        {
            InitializeComponent();
        }

        Kitap seciliKitap = new Kitap();
        KitapManager _kitapManager = new KitapManager(new DAL.Repositories.KitapRepository(new KutuphaneOtomasyonDBContext()));
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliKitap.BarkodNo = int.Parse(txtBarkodNo.Text);
            seciliKitap.YazarAdi = txtYazarAdi.Text;
            seciliKitap.Yayinevi = txtYayinevi.Text;
            seciliKitap.sayfasayisi = int.Parse(txtSayfaSayisi.Text);
            seciliKitap.Turu = comboTuru.Text;
            seciliKitap.StokSayisi = int.Parse(txtStokSayisi.Text);
            seciliKitap.RafNo = int.Parse(txtRafNo.Text);
            seciliKitap.Aciklama = txtAciklama.Text;
            _kitapManager.Update(seciliKitap.Id);
            ListeGuncelle();
        }




        public void ListeGuncelle()
        {
            dataGridView1.DataSource = _kitapManager.GetAll();
        }
        private void KitapGuncellemeFormu_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliKitap = _kitapManager.GetById(x => x.Id == seciliID);
            txtBarkodNo.Text = seciliKitap.BarkodNo.ToString();
            txtKitapAdı.Text = seciliKitap.KitapAdi;
            txtYazarAdi.Text = seciliKitap.YazarAdi;
            txtYayinevi.Text = seciliKitap.Yayinevi;
            txtSayfaSayisi.Text = seciliKitap.sayfasayisi.ToString();
            comboTuru.Text = seciliKitap.Turu;
            txtStokSayisi.Text = seciliKitap.StokSayisi.ToString();
            txtRafNo.Text = seciliKitap.RafNo.ToString();
            txtAciklama.Text = seciliKitap.Aciklama;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKitap.Id != null && seciliKitap.Id > 0)
            {
                _kitapManager.Delete(seciliKitap.Id);
            }
            else
            {
                MessageBox.Show("Bir kitap seçin");
            }

            ListeGuncelle();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            seciliKitap = _kitapManager.GetById(x => x.BarkodNo == Convert.ToInt32(txtBarkodNoAra.Text));

            if (seciliKitap != null)
            {

                txtBarkodNo.Text = seciliKitap.BarkodNo.ToString();

                seciliKitap.KullaniciId = seciliKitap.Id;
                _kitapManager.Update(seciliKitap.Id);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string tcAra=txtBarkodNoAra.Text;
        //    List<Kullanici> matchingPeople =.(txttcAra);
        //    dataGridView1.
        //}
    }

}
