using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concrate
{
    public class Kullanici
    {
        public int Id { get; set; }
        public int TC { get; set; }
        public string Adi { get; set; }
        public int Yas { get; set; }
        public string  Cinsiyet { get; set; }
        public int Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public int OkuKitapSayisi { get; set; }
      

    }
}
