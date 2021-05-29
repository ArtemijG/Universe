using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniverseDB.DataBase.Entities
{
    public class GameGenre
    {
        [Required]
        public Guid Id { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
