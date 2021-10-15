using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCountries.Interfaces
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        Task<T> GetByName(string name);
        Task<T> Post(T o);
        Task<T> Put(T o);
        Task Delete(T o);
        Task<bool> Any(int id);
    }
}
