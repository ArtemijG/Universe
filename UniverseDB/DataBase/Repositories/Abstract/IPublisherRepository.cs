using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories.Abstract
{
    public interface IPublisherRepository
    {
        IQueryable<Publisher> GetPublishers();
        Publisher GetPublisherById(Guid id);
        void SavePublisher(Publisher entity);
        void DeletePublisher(Guid id);
    }
}
