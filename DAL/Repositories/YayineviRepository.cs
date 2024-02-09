using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class YayineviRepository : BaseRepository<Yayinevi>
    {
        public YayineviRepository(KutuphaneOtomasyonDBContext context) : base(context)
        {
        }
    }
}
