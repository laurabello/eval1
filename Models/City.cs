using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace evaluation1.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required(ErrorMessage = "Le nom est requis."), MaxLength(30)]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Display(Name = "Pays")]
        public string Country { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
