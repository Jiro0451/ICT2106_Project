using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class Booking
    {
        [Required]
        public string TourID { get; set; }
        [Required]
        public string TourName { get; set; }
        [Required]
        public string ClientID { get; set; }

        [Required]
        public string DepartureDate { get; set; }
        [Required]
        public string NumberOfPeople { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Range(80000000,99999999)]
        //Results in a funny error message "Must be from 80000000 to 99999999"
        public int ContactNo { get; set; }

        //Optional
        public string SpecialRequest { get; set; }
    }
}
