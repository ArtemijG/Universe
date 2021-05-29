using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseDB.DataBase.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }

        public double Balance { get; set; }



        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
