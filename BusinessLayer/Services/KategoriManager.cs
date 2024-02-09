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
    public class KategoriManager
    {
        KategoriRepository _kategoriRepository;

        public KategoriManager(KategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }
        public void Create(Kategori item)
        {
            _kategoriRepository.Create(item);
        }

        public void Update(int id)
        {
            _kategoriRepository.Update(id);
        }
        public void Delete(int id)
        {
            _kategoriRepository.Delete(id);
        }
        public List<Kategori> GetAll()
        {
            return _kategoriRepository.GetAll();
        }
        public Kategori GetById(Expression<Func<Kategori ,bool>> expression)
        {
            return _kategoriRepository.GetById(expression);
        }
        public List<Kategori> GetFilter(Expression<Func<Kategori, bool>> expression)
        {
            return _kategoriRepository.GetFilter(expression);
        }
    }
}
