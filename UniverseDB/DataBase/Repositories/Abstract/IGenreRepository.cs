using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface IGenreRepository
    {
        void SaveGenre(Genre entity);
        void DeleteGenre(Guid id);
    }
}
