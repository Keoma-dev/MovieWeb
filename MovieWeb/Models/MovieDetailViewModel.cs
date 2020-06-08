using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Models
{
    public class MovieDetailViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime Releasedate { get; set; }

        public string CalculateReleaseDateMessage(DateTime releaseDate)
        {
            if (releaseDate > DateTime.Now)
            {                
                return $"Nog {(releaseDate - DateTime.Now).Days.ToString()} dagen tot release";
            }
            else
            {
                return "Out Now";
            }
        }
    }
}
