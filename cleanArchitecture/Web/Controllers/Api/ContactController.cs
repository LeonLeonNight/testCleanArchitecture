using ApplicationCore.Entities.ContactAggregate;
using Infrastructure.Contacts.Request;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers.Api
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Contact>> GetContact([FromBody] ContactModel contactModel)
        {
            var response = new CreateContactRequest();
            return response;
        }
    }
}
