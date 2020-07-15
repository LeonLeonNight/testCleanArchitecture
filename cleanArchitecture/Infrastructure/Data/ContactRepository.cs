using ApplicationCore.Entities.ContactAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ContactRepository : EfRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationContext dbContext) : base(dbContext) { }


    }
}
