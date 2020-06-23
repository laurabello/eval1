using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace evaluation1.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        [Display(Name = "Disponible")]
        public bool Available { get; set; } = true;

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }
    }
}
