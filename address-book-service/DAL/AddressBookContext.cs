using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AddressBookContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options) { }
    }
}
