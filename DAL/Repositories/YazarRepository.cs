using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class YazarRepository : BaseRepository<Yazar>
    {
        public YazarRepository(KutuphaneOtomasyonDBContext context) : base(context)
        {
        }
    }
}
