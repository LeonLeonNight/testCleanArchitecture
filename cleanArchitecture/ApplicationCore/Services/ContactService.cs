using ApplicationCore.Entities.ContactAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services
{
    public class ContactService : IContactService
    {
        private readonly IAsyncRepository<Contact> _contactRepository;

        public ContactService(IAsyncRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }


    }
}
