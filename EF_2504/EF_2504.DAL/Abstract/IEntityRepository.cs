using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Abstract
{
    public interface IEntityRepository<T> where T:class
    {
        void Add(T entity);             //Create
        List<T> GetAll(Expression<Func<T,bool>>filter=null);               //Read
        T Get(Expression<Func<T, bool>> filter = null);                        //read
        void Update(T entity);          //Update
        void Delete(T entity);          //Delete

    }


}
