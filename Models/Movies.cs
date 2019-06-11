using System;
using System.ComponentModel.DataAnnotations;

namespace SanookMovie.Models
{
    public class Movies
    {
        public int Id {get; set;}
        
        public string Title {get; set;}

        public string Genre {get; set;} 

        // [DateType(DateType.Date)]
        public DateTime ReleaseDate {get; set;} 
    }
}