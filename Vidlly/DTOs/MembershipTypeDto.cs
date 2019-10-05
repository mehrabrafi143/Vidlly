using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.DTOs
{
    public class MembershipTypeDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public byte DiscoutRate { get; set; }
    }
}