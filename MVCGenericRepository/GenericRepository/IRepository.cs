using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGenericRepository.GenericRepository
{
    
interface IRepository<T> where T : class
    {
        IEnumerable<T> getAll();
        T getById(object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Object Id);
        void Save();
    }
}
