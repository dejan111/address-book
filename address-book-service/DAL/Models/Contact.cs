using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MyProperty { get; set; }
        public string[] PhoneNum { get; set; }

        public ContactAddress Address { get; set; }
    }
}
