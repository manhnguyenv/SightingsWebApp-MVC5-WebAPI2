using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public interface IBaseRepository<T>
    {
        T Add(T entity);
        void Remove(T entity);
        Task<T> Update(T entity);
    }
}
