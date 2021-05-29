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
    public class EFPublisherRepository:IPublisherRepository
    {
        private readonly AppDbContext context;
        public EFPublisherRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Publisher> GetPublishers()
        {
            return context.Publishers;
        }
        public Publisher GetPublisherById(Guid id)
        {
            return context.Publishers.FirstOrDefault(x => x.Id == id);
        }
        public void SavePublisher(Publisher entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeletePublisher(Guid id)
        {
            context.Publishers.Remove(new Publisher() { Id = id });
            context.SaveChanges();
        }
    }
}
