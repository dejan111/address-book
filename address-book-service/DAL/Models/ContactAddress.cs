using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ContactAddress
    {
        public int ContactAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
