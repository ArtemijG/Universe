using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverseDB.DataBase.Entities
{
    public class Developer
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }



        public IList<Game> Games { get; set; }
    }
}
