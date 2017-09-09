using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FromScratch.Web.Api.Controllers
{
    public class BaseApiController : ApiController
    {
        protected readonly IUnitOfWork _uow;
        public BaseApiController(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
