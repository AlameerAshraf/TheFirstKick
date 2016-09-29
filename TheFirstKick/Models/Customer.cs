using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheFirstKick.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string AccountantNumber { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }

    }
}