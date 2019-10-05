using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public DateTime? CreateTime { get; set; }
        [Required] public string UserId { get; set; }
    }
}