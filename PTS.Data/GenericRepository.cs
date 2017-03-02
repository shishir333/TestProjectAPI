using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTS.Data.DB;

namespace PTS.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ProgisticsEntities entities = null;
        IDbSet<T> _objectSet;
        

        public GenericRepository(ProgisticsEntities _entities)
        {
            entities = _entities;
            _objectSet = entities.Set<T>();
            
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _objectSet.Where(predicate);
            }

            return _objectSet.AsEnumerable();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _objectSet.First(predicate);
        }

        public bool Add(T entity)
        {
            _objectSet.Add(entity);
            return true;
        }

        public bool Attach(T entity)
        {
            _objectSet.Attach(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            _objectSet.Remove(entity);
            return true;
        }
    }
}
