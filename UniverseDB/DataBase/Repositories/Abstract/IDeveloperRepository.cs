using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface IDeveloperRepository
    {
        IQueryable<Developer> GetDevelopers();
        Developer GetDeveloperById(Guid id);
        void SaveDeveloper(Developer entity);
        void DeleteDeveloper(Guid id);
    }
}
