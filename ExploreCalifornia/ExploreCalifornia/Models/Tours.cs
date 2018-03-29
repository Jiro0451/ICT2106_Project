using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExploreCalifornia.Models
{
    public class Tours
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name="Length in days")]
        [Range(1,99)]
        public int Length { get; set; }

        public decimal Price { get; set; }
        public string Rating { get; set; }

        [Display(Name="Includes meals")]
        public bool IncludesMeals { get; set; }
    }
}
