using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace evaluation1.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Le nom de l'hôtel est requis."), MaxLength(30)]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Display(Name = "Photo")]
        public string PicUrl { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Téléphone")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "L'email n'est pas valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Au moins un élément d'adresse est requis."), MaxLength(30)]
        [Display(Name = "Adresse 1")]
        public string Adress1 { get; set; }

        [Display(Name = "Adresse 2")]
        public string Adress2 { get; set; }

        [Required(ErrorMessage = "La ville est requise.")]
        [Display(Name = "Ville")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Range(0, 5, ErrorMessage = "La valeur doit ête entre 0 et 5.")]
        [Display(Name = "Etoiles")]
        public int Stars { get; set; } = 0;

        [Required(ErrorMessage = "Veuillez indiquer le nombre de chambres de l'hôtel.")]
        [Display(Name = "Chambres")]
        public int Rooms { get; set; }
    }
}
