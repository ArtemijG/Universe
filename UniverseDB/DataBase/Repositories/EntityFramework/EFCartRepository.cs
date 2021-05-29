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
    public class EFCartRepository:ICartRepository
    {
        private readonly AppDbContext context;
        public EFCartRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void SaveCart(Cart entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCart(Guid id)
        {
            context.Cart.Remove(new Cart() { Id = id });
            context.SaveChanges();
        }
    }
}
