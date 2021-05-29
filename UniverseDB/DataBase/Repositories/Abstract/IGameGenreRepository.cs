using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface IGameGenreRepository
    {
        void SaveGameGenre(GameGenre entity);
        void DeleteGameGenre(Guid id);
    }
}
