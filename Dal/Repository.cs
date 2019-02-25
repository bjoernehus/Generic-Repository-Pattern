using Microsoft.EntityFrameworkCore;
using PetShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Dal
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public ShopContext _dbContext;
        private DbSet<T> _entities;       

        public Repository(ShopContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();         
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id); ;
        }


    }
}
