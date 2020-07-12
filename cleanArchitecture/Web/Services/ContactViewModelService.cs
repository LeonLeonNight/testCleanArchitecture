using ApplicationCore.Entities.ContactAggregate;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;
using Web.ViewModels;

namespace Web.Services
{
    public class ContactViewModelService : IContactViewModelService
    {
        protected readonly ContactRepository _asyncRepository;

        public ContactViewModelService(ContactRepository asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
    }
}
