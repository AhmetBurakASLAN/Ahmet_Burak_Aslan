using DatabaseImageProject.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Concrete
{
    public class BaseRepository<T> : IRespository<T> where T : class
    {
        public void Add(T enitity)
        {
            var _context = new SalesDbContext();
            _context.Add(enitity);
            _context.SaveChanges();
        }

        public void Delete(T entitiy)
        {
            var _context = new SalesDbContext();
            _context.Remove(entitiy);
            _context.SaveChanges();
        }

        public T Get(T entity)
        {
            var _context = new SalesDbContext();
           return _context.Set<T>().SingleOrDefault();
        }

        public List<T> GetAll()
        {
            var _context = new SalesDbContext();
           return _context.Set<T>().ToList();
        }
    }
}
