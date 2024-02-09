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
    public class YazarManager
    {
        YazarRepository _yazarRepository;

        public YazarManager(YazarRepository yazarRepository)
        {
            _yazarRepository = yazarRepository;
        }

        public void Create(Yazar item)
        {
            _yazarRepository.Create(item);
        }
        public void Update(int id)
        {
            _yazarRepository.Update(id);
        }
        public void Delete(int id)
        {
            _yazarRepository.Delete(id);
        }
        public List<Yazar> GetAll()
        {
            return _yazarRepository.GetAll();
        }
        public Yazar GetById(Expression<Func<Yazar, bool>> expression)
        {
            return _yazarRepository.GetById(expression);
        }
        public List<Yazar> GetFilter(Expression<Func<Yazar, bool>> expression)
        {
            return _yazarRepository.GetFilter(expression);
        }
    }
}
