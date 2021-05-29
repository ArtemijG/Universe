using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;
using UniverseDB.DataBase.Repositories.Abstract;

namespace UniverseDB.DataBase.Repositories.EntityFramework
{
    public class EFGameGenreRepository:IGameGenreRepository
    {
        private readonly AppDbContext context;
        public EFGameGenreRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveGameGenre(GameGenre entity) 
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteGameGenre(Guid id)
        {
            context.GameGenres.Remove(new GameGenre() { Id = id });
            context.SaveChanges();
        }
    }
}
