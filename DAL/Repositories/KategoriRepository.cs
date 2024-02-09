using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KategoriRepository : BaseRepository<Kategori>
    {
        public KategoriRepository(KutuphaneOtomasyonDBContext context) : base(context)
        {
        }
    }
}
