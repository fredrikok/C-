using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fullstackmovie.Server.Movie
{
    public class Movie
    {
        [Required]
        public int ID {get; set;}
        public string Name {get; set;}

        public string Description {get; set;}

        public string URL {get; set;}
    }
}