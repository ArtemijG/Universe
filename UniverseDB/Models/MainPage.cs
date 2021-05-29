using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;
using UniverseDB.DataBase.Repositories;

namespace UniverseDB.Models
{

    public class MainPage
    {
        private AppDbContext db;

        public MainPage(AppDbContext db)
        {
            this.db = db;
            List<Game> game = db.Games.ToList();
        }
    }
}
