using Luca_Pacinotti_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.InterfaceRepository
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Menu GetByCode(int id);
    }
}
