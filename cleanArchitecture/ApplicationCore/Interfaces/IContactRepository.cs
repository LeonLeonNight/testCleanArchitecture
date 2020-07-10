using ApplicationCore.Entities.ContactAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IContactRepository : IAsyncRepository<Contact>
    {
    }
}
