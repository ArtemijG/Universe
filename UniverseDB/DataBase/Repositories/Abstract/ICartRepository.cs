using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface ICartRepository
    {
       
        void SaveCart(Cart entity);
        void DeleteCart(Guid id);
    }
}
