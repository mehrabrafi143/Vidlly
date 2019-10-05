using System.Collections.Generic;

namespace Vidlly.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public byte DiscoutRate { get; set; }

    }
}