using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        [Required(AllowEmptyStrings = false, ErrorMessage ="Film moet een genre hebben!")]
        [MinLength(1, ErrorMessage ="Minstens 1 karakter")]
        [MaxLength(20, ErrorMessage ="Maximum 20 karakters")]
        public string Genre { get; set; }
        [DisplayName("Release Datum")]
        public int Releasedate { get; set; }
    }
}
