using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniverseDB.DataBase.Entities
{
    public class Publisher
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }



        public IList<Game> Games { get; set; }
    }
}
