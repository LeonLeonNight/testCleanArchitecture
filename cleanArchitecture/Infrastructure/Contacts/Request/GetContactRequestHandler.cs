using ApplicationCore.Entities.ContactAggregate;
using ApplicationCore.Interfaces;
using AutoMapper;
using Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Contacts.Request
{
    public class GetContactRequestHandler : IRequestHandler<GetContactRequest, Contact>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly ContactRepository _repository;

        public GetContactRequestHandler(
            IMapper mapper, 
            IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<Contact> Handle(GetContactRequest request, CancellationToken cancellationToken)
        {
            return await;
        }
    }
}
