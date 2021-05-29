using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseDB.DataBase.Entities
{
    public class Role : IdentityRole
    {
        [Required]
        public new Guid Id { get; set; }

        [Required]
        public new string Name{ get; set; }


       // public IList<__User> Users { get; set; }

    }
}
