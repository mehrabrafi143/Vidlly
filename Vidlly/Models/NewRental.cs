using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{
    public class NewRental
    {

        public int CustomerId { get; set; }
        public IList<int> MovieId { get; set; }

    }
}