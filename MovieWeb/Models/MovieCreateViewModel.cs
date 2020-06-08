using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MovieWeb.Models
{
    public class MovieCreateViewModel
    {
        [DisplayName("Titel")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Titel is verplicht!")]
        [MinLength(1, ErrorMessage ="Titel moet minstens 1 karakter bevatten!")]
        [MaxLength(30, ErrorMessage ="Maximum 30 karakters!")]

        public string Title { get; set; }
        [DisplayName("Omschrijving")]
        [MaxLength(250)]
        public string Description { get; set; }
        [DisplayName("Genre")]
        //[Required(AllowEmptyStrings = false, ErrorMessage ="Film moet een genre hebben!")]
        //[MinLength(1, ErrorMessage ="Minstens 1 karakter")]
        [MaxLength(20, ErrorMessage ="Maximum 20 karakters")]
        public string Genre { get; set; }
        [DisplayName("Release Datum")]
        [Range(typeof(DateTime), "01/01/1900", "01/01/2070", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Releasedate { get; set; }
    }
}
