using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Repository
{
    interface IRepository<T>
    {
        List<T> GetAll();
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}
