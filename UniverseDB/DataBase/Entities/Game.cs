using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace UniverseDB.DataBase.Entities
{
    public class Game
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsGame { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Cost { get; set; }

        
        public string PicturePath { get; set; }



        //Связи
        

        public Guid DeveloperId { get; set; }
        public Developer Developer { get; set; }

        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }

       
        public Cart Cart { get; set; }


    }
}
