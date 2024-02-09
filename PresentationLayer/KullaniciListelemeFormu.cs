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
    public partial class KullaniciListelemeFormu : Form
    {
        public KullaniciListelemeFormu()
        {
            InitializeComponent();
        }

        Kullanici seciliKullanici = new Kullanici();
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new KutuphaneOtomasyonDBContext()));

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullanici.Id != null && seciliKullanici.Id > 0)
            {
                seciliKullanici.TC = int.Parse(txtTc.Text);
                seciliKullanici.Adi = txtAdSoyad.Text;
                seciliKullanici.Yas = int.Parse(txtYas.Text);
                seciliKullanici.Cinsiyet = comboCinsiyet.Text;
                seciliKullanici.Telefon = int.Parse(txtTel.Text);
                seciliKullanici.Adres = txtAdres.Text;
                seciliKullanici.Email = txtMail.Text;
                seciliKullanici.OkuKitapSayisi = int.Parse(txtOkuKitapSayi.Text);
                _kullaniciManager.Update(seciliKullanici.Id);
                ListeGuncelle();
            }
            else
            {
                MessageBox.Show("Bir kullanıcı seçin");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliKullanici = _kullaniciManager.GetById(x => x.Id == seciliID);
            txtTc.Text = seciliKullanici.TC.ToString();
            txtAdSoyad.Text = seciliKullanici.Adi;
            txtYas.Text = seciliKullanici.Yas.ToString();
            comboCinsiyet.Text = seciliKullanici.Cinsiyet;
            txtTel.Text = seciliKullanici.Telefon.ToString();
            txtAdres.Text = seciliKullanici.Adres;
            txtMail.Text = seciliKullanici.Email;
            txtOkuKitapSayi.Text = seciliKullanici.OkuKitapSayisi.ToString();
        }

        public void ListeGuncelle()
        {
            dataGridView1.DataSource = _kullaniciManager.GetAll();
        }
        private void KullaniciListelemeFormu_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            //  dataGridView1.DataSource =  _kullaniciManager.GetFilter(x => x.TC==txtTc.Text).ToList();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKullanici.Id != null && seciliKullanici.Id > 0)
            {
                _kullaniciManager.Delete(seciliKullanici.Id);
            }
            else
            {
                MessageBox.Show("Bir Kullanıcı seçin");
            }

            ListeGuncelle();
        

    }
}
}
