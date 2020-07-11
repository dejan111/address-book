using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Repositories;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public AddressBookContext AddressBookContext
        {
            get { return _context as AddressBookContext; }
        }

        public ContactRepository(AddressBookContext context) : base(context)
        { }

        public IEnumerable<Contact> GetContacts()
        {
            var contacts = AddressBookContext.Contacts.Include(m => m.Address);

            return contacts;
        }

        public Contact GetContact(int id)
        {
            return AddressBookContext.Contacts.Include(m => m.Address).Where(m => m.Id == id).FirstOrDefault();
        }
    }
}
