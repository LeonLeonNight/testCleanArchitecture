using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.ContactAggregate;

namespace Infrastructure.Contacts.Request
{
    public class CreateContactRequest : 
        IRequest<ApplicationCore.Entities.ContactAggregate.Contact>
    {
        public Contact Contact { get; set; }
    }
}
