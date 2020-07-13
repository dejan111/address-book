using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace Core.Repositories
{
    public interface IContactRepository : IRepository<Contact>
    {
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetContacts(string name);
        Contact GetContact(int id);
    }
}
