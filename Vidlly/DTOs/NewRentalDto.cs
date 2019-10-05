using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidlly.DTOs
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public IList<int> MovieIds { get; set; }
    }
}