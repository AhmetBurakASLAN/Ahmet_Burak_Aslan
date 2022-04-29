using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Abstract
{
    public interface IRespository<T>where T:class
    {
        void Add(T enitity);
        List<T> GetAll();
        T Get(T entity);
        void Delete(T entitiy);
        
    }
}
