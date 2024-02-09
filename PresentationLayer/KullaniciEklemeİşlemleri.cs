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
    public partial class KullaniciEklemeİşlemleri : Form
    {
        public KullaniciEklemeİşlemleri()
        {

            InitializeComponent();
        }
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new KutuphaneOtomasyonDBContext()));

        private void button1_Click(object sender, EventArgs e)
        {

            _kullaniciManager.Create(new Kullanici
            {
                TC = int.Parse(txtTc.Text),
                Adi = txtAdSoyad.Text,
                Yas = int.Parse(txtYas.Text),
                Cinsiyet = comboCinsiyet.Text,
                Telefon = int.Parse(txtTel.Text),
                Adres = txtAdres.Text,
                Email = txtMail.Text,
                OkuKitapSayisi = int.Parse(txtOkuKitapSayi.Text),
            });
            MessageBox.Show("Kullanıcı Eklendi");
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciEklemeFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
