using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AddressBookContext : DbContext
    {
        private readonly string _connectionString;
        private const string CONNECTION_STRING = "Server=localhost;Port=5432;Database=AddressBookDb;User Id=postgres;Password=suky89;";
        public DbSet<Contact> Contacts { get; set; }

        public AddressBookContext()
        { }

        public AddressBookContext(string connectionString) 
        {
            _connectionString = connectionString;
        }
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasIndex(p => new { p.Name}).IsUnique();

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Name = "John Johnes",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134", "0952211478", "0995135647"}
                },
                new Contact
                {
                    Id = 2,
                    Name = "Ivan Blatazar",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "099578681" }
                },
                new Contact
                {
                    Id = 3,
                    Name = "Ivana Ivanović",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134", "0952211478", "0995135647" }
                },
                new Contact
                {
                    Id = 4,
                    Name = "Ivanka Perić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 5,
                    Name = "Iva Gordanić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 6,
                    Name = "Ivor Beleter",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134", "0952211478" }
                },
                new Contact
                {
                    Id = 7,
                    Name = "Petar Kajić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 8,
                    Name = "Ingrid Budić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 9,
                    Name = "Igor Igorić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 10,
                    Name = "Valentino Valentić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 11,
                    Name = "Barbara Ivković",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 12,
                    Name = "Tea Teić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                },
                new Contact
                {
                    Id = 13,
                    Name = "Viktor Draganić",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    PhoneNum = new string[] { "0992221134" }
                }
            );

            modelBuilder.Entity<ContactAddress>().HasData(
                new ContactAddress
                {
                    ContactAddressId = 1,
                    ContactId = 1,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 2,
                    ContactId = 2,
                    Address = "Zlarinska 6",
                    City = "Šibenik",
                    Country = "Hrvatska",
                    ZipCode = 40235
                },
                new ContactAddress
                {
                    ContactAddressId = 3,
                    ContactId = 3,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 4,
                    ContactId = 4,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 5,
                    ContactId = 5,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 6,
                    ContactId = 6,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 7,
                    ContactId = 7,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 8,
                    ContactId = 8,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 9,
                    ContactId = 9,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 10,
                    ContactId = 10,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 11,
                    ContactId = 11,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 12,
                    ContactId = 12,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                },
                new ContactAddress
                {
                    ContactAddressId = 13,
                    ContactId = 13,
                    Address = "Svetog Petra 2",
                    City = "Hvar",
                    Country = "Hrvatska",
                    ZipCode = 55223
                }
            );
        }
    }
}
