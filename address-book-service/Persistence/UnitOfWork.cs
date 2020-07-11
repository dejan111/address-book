using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Repositories;
using DAL;
using Persistence.Repositories;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AddressBookContext _context;
        private IContactRepository _contacts;

        public IContactRepository Contacts
        {
            get
            {
                if (_contacts == null)
                {
                    _contacts = new ContactRepository(_context);
                }

                return _contacts;
            }
        }

        public UnitOfWork(AddressBookContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
