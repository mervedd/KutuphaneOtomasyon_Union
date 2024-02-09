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
    public class YayineviManager
    {
        YayineviRepository _yayineviRepository;

        public YayineviManager(YayineviRepository yayineviRepository)
        {
            _yayineviRepository = yayineviRepository;
        }

        public void Create(Yayinevi item)
        {
            _yayineviRepository.Create(item);
        }

        public void Update(int id)
        {
            _yayineviRepository.Update(id);
        }
        public void Delete(int id)
        {
            _yayineviRepository.Delete(id);
        }
        public List<Yayinevi> GetAll()
        {
            return _yayineviRepository.GetAll();
        }
        public Yayinevi GetById(Expression<Func<Yayinevi, bool>> expression)
        {
            return _yayineviRepository.GetById(expression);
        }
        public List<Yayinevi> GetFilter(Expression<Func<Yayinevi, bool>> expression)
        {
            return _yayineviRepository.GetFilter(expression);
        }
    }
}
