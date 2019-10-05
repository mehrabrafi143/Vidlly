using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Gener> Geners { get; set; }
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Gener Gener { get; set; }

        [Required]
        [Display(Name = "Gener  Type")]
        public byte GenerId { get; set; }

        public DateTime? DayOfAdded { get; set; }

        [Required]
        [Display(Name = "Published Date") ]
        [PublishAfter1Day] 
        public DateTime? PublishDate { get; set; }
        [Required]
        [Display(Name = "Nuber in stock")]
        public byte? NumberInStock { get; set; }
        public byte AvailInStock { get; set; }

        public string Title => Id == 0 ? "New Movie" : "Update Movie";
    }
}