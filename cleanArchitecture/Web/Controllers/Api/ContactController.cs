using ApplicationCore.Entities.ContactAggregate;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers.Api
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        
    }
}
