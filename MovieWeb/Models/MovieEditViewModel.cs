using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace MovieWeb.Models
{
    public class MovieEditViewModel
    {
        [DisplayName("Titel")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Titel is verplicht!")]
        [MinLength(1, ErrorMessage = "Titel moet minstens 1 karakter bevatten!")]
        [MaxLength(30, ErrorMessage = "Maximum 30 karakters!")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime Releasedate { get; set; }
    }
}
