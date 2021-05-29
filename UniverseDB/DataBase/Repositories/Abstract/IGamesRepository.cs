using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface IGamesRepository
    {
        IQueryable<Game> GetGames();
        Game GetGameById(Guid id);
        void SaveGame(Game entity);
        void DeleteGame(Guid id);
    }
}
