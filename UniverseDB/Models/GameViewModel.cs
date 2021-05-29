using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;
using System.Collections;

namespace UniverseDB.Models
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        public Developer Developer { get; set; }
        public Publisher Publisher { get; set; }
    }
}
