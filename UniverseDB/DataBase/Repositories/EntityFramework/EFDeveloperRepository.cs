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
    public class EFDeveloperRepository:IDeveloperRepository
    {
        private readonly AppDbContext context;
        public EFDeveloperRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Developer> GetDevelopers() 
        {
            return context.Developers;
        }
        public Developer GetDeveloperById(Guid id)
        {
            return context.Developers.FirstOrDefault(x => x.Id == id);
        }
        public void SaveDeveloper(Developer entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteDeveloper(Guid id)
        {
            context.Developers.Remove(new Developer() { Id = id });
            context.SaveChanges();
        }
    }
}
