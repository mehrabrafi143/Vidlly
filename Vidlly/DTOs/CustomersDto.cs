using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.DTOs
{
    public class CustomersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MembershipTypeDto MemberShipType { get; set; }
        public DateTime Birthdate { get; set; }
    }
}