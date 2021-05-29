using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Repositories.Abstract;

namespace UniverseDB.DataBase
{
    public class DataManager
    {
        public ICartRepository Cart { get; set; }
        public IDeveloperRepository Developer { get; set; }
        public IGameGenreRepository GameGenre { get; set; }
        public IGamesRepository Games { get; set; }
        public IGenreRepository Genre { get; set; }
        public IPublisherRepository Publisher { get; set; }

        public DataManager(ICartRepository CartRepository,  IDeveloperRepository DeveloperRepository, IGameGenreRepository GameGenreRepository, 
            IGamesRepository GamesRepository, IGenreRepository GenreRepository, IPublisherRepository PublisherRepository )
        {
            Cart = CartRepository;
            Developer = DeveloperRepository;
            GameGenre = GameGenreRepository;
            Games = GamesRepository;
            Genre = GenreRepository;
            Publisher = PublisherRepository;

        }
    }
}
