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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        Kitap seciliKitap = new Kitap();
        KitapManager _kitapManager = new KitapManager(new DAL.Repositories.KitapRepository(new KutuphaneOtomasyonDBContext()));

        private void btnEmanette_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kitapManager.GetFilter(x => x.KullaniciId > 0);
        }

        private void btnBosta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kitapManager.GetFilter(x => x.KullaniciId == null);
        }
    }
}
