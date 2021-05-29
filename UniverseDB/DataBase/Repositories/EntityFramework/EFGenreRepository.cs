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
    public class EFGenreRepository:IGenreRepository
    {
        private readonly AppDbContext context;
        public EFGenreRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveGenre(Genre entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteGenre(Guid id)
        {
            context.Genres.Remove(new Genre() { Id = id });
            context.SaveChanges();
        }
    }
}
