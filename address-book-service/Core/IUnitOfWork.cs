using System;
using System.Collections.Generic;
using System.Text;
using Core.Repositories;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository Contacts { get; }

        int Complete();
    }
}
