using ApplicationCore.Entities.ContactAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Contacts.Request
{
    public class GetContactRequest : IRequest<Contact>
    {

    }
}
