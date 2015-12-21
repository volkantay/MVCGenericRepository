using MVCGenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGenericRepository.GenericRepository
{

public class Repository<T> : IRepository<T> where T : class
    {
        private DemoRepoContext db;
        private DbSet<T> dbSet;

        public Repository()
        {
            this.db = new DemoRepoContext();
            dbSet = db.Set<T>();
        }

        public IEnumerable<T> getAll()
        {
            return dbSet.ToList();
        }

        public T getById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object Id)
        {
            T getObjById = dbSet.Find(Id);
            dbSet.Remove(getObjById);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}
