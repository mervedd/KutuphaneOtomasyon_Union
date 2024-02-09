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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEklemeİşlemleri kullaniciEkleme = new KullaniciEklemeİşlemleri();
            kullaniciEkleme.ShowDialog();
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            KullaniciListelemeFormu kullaniciListeleme = new KullaniciListelemeFormu();
            kullaniciListeleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapEklemeİşlemleri kitapEkleme = new KitapEklemeİşlemleri();
            kitapEkleme.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapListelemeİşlemleri kitapListeleme = new KitapListelemeİşlemleri();
            kitapListeleme.ShowDialog();
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {
            EmanetKitapİşlemleri emanetKitapVerme = new EmanetKitapİşlemleri();
            emanetKitapVerme.ShowDialog();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            Rapor sıralama = new Rapor();
            sıralama.ShowDialog();
        }
    }
}
