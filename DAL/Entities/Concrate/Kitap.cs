using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concrate
{
    public class Kitap
    {
        public static int seciliKitap;

        public int Id { get; set; }

        
        public string KitapAdi { get; set; }

        //Foreign Key
       // public string YazarId { get; set; }
        //Navigation Property
        public string YazarAdi { get; set; }
        public int BarkodNo { get; set; }

        public int sayfasayisi { get; set; }
      //  public int KategoriId { get; set; }
        public string Turu { get; set; }
        public int StokSayisi { get; set; }
        public string Yayinevi { get; set; }
        public int RafNo{ get; set; }
        public string Aciklama { get; set; }

        public  int? KullaniciId { get; set; } //foreign key

        public Kullanici? Kullanici { get; set; } //navigation property

    }
}
