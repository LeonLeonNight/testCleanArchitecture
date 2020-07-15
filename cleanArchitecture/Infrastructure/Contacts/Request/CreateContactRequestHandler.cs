using ApplicationCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Contacts.Request
{
    public class CreateContactRequestHandler : 
        IRequestHandler<CreateContactRequest, 
            ApplicationCore.Entities.ContactAggregate.Contact>
    {
        private readonly IAsyncRepository<ApplicationCore.Entities.ContactAggregate.Contact> _repository;

        public CreateContactRequestHandler(
            IAsyncRepository<ApplicationCore.Entities.ContactAggregate.Contact> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationCore.Entities.ContactAggregate.Contact> Handle(
            CreateContactRequest request,
            CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request.Contact);
        }
    }
}
