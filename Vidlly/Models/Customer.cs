using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{               
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [Required]
        [Min18YearsOld]
        [Display(Name = "Birth Date")]
        public DateTime? Birthdate { get; set; }

    }
}