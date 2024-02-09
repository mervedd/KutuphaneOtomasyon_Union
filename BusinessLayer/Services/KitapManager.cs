using DAL.Entities.Concrate;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class KitapManager
    {
        KitapRepository _kitapRepository;

        public KitapManager(KitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

        public void Create( Kitap item)
        {
            _kitapRepository.Create(item);
        }
        public void Update(int id)
        {
            _kitapRepository.Update(id);
        }
        public void Delete(int id)
        {
            _kitapRepository.Delete(id);
        }
        public List<Kitap> GetAll()
        {
            return _kitapRepository.GetAll();
        }
        public Kitap GetById(Expression<Func<Kitap, bool>> expression)
        {
            return _kitapRepository.GetById(expression);
        }
        public List<Kitap> GetFilter(Expression<Func<Kitap, bool>> expression)
        {
            return _kitapRepository.GetFilter(expression);
        }
    }
}
