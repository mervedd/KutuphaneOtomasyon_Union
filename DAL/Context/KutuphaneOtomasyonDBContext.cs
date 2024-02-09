using DAL.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class KutuphaneOtomasyonDBContext:DbContext
    {

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Yayinevi>Yayinevleri { get; set; }
        public DbSet<Yazar> Yazarlar{ get; set; }
        public DbSet<Kitap>Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LCDHNHB;database=KutuphaneOtomasyon;Integrated Security=True; trustservercertificate=true;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
