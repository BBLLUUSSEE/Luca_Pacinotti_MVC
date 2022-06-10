using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.InterfaceRepository
{
    public interface IRepository<T>
    {   
        List<T> GetAll();
        T Add(T item);
        T Update(T item);
        bool Delete(T item);
    }
}
