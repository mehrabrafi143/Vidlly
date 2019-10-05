using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public Movie Movie { get; set; }

        [Required]
        public int MovieId { get; set; }
    }
}