using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidlly.Models
{
    public class Gener
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList<Movie> Movies { get; set; }
    }
}