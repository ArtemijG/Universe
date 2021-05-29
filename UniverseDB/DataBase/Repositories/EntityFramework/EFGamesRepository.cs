using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;
using UniverseDB.DataBase.Repositories.Abstract;

namespace UniverseDB.DataBase.Repositories.EntityFramework
{
    public class EFGamesRepository : IGamesRepository
    {
        private readonly AppDbContext context;
        public EFGamesRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Game> GetGames()
        {
            return context.Games;
        }
        public Game GetGameById(Guid id)
        {
            return context.Games.FirstOrDefault(x => x.Id == id);
        }
        public void SaveGame(Game entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteGame(Guid id)
        {
            context.Games.Remove(new Game() { Id = id });
            context.SaveChanges();
        }
    }
}
