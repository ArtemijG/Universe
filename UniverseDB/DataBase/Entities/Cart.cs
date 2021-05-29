using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniverseDB.DataBase.Entities
{
    public class Cart
    {
        [Required]
        public Guid Id { get; set; }

        public DateTime PurchaseDate { get; set; }




        //Conventions 
        public string UserIdFK { get; set; }
        public IdentityUser User { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

    }
}
