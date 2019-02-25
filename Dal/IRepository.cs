using PetShop.Models;
using System.Collections.Generic;


namespace PetShop.Dal
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        //  etc ...
        //  IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        //  void Add(T entity);
        //  void Delete(T entity);
        //  void Update(T entity);
    }
}
