using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }

        public static  byte PayAsYouGo = 1;
        public static  byte Unknown = 0;

        public string Title
        {
            get
            {
                return Customer.Id == 0 ? "New Customer" : "Update Customer";
            }
            
        }



    }
}