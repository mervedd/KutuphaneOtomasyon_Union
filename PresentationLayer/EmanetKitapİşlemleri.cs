using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using DAL.Repositories;
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
    public partial class EmanetKitapİşlemleri : Form
    {
        public EmanetKitapİşlemleri()
        {
            InitializeComponent();
        }
        Kitap seciliKitap = new Kitap();
        Kullanici seciliKullanici = new Kullanici();
        KitapManager _kitapManager = new KitapManager(new DAL.Repositories.KitapRepository(new KutuphaneOtomasyonDBContext()));
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new KutuphaneOtomasyonDBContext()));

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (seciliKullanici.Id > 0 && seciliKitap.Id > 0)
            {
                seciliKitap.KullaniciId = seciliKullanici.Id;
            }
            MessageBox.Show("Teslim Edildi");

        }


        public void listele()
        {

            dataGridView1.DataSource = _kitapManager.GetAll();


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliKitap = _kitapManager.GetById(x => x.Id == seciliID);
            txtBarkodNo.Text = seciliKitap.BarkodNo.ToString();
            txtKitapAdi.Text = seciliKitap.KitapAdi;
            txtYazarAdi.Text = seciliKitap.YazarAdi;
            txtYayinevi.Text = seciliKitap.Yayinevi;
            txtSayfaSayisi.Text = seciliKitap.sayfasayisi.ToString();

        }

        private void EmanetKitapVermeİşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            seciliKullanici = _kullaniciManager.GetById(x => x.TC == Convert.ToInt32(txtTCAra.Text));

            if (seciliKullanici != null)
            {

                txtTCAra.Text = seciliKullanici.TC.ToString();
                txtAdSoyad.Text = seciliKullanici.Adi;
                txtYas.Text = seciliKullanici.Yas.ToString();
                txtTelefon.Text = seciliKullanici.Telefon.ToString();

                seciliKitap.KullaniciId = seciliKullanici.Id;
                _kitapManager.Update(seciliKitap.Id);
            }
        }

        private void btnİade_Click(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            seciliKitap.KullaniciId = null;
            _kitapManager.Update(seciliKitap.Id);
            listele();
        }
    }
}
