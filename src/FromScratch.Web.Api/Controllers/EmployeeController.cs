using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FromScratch.Domain.Interfaces;
using FromScratch.Domain.Entities;

namespace FromScratch.Web.Api.Controllers
{
    public class EmployeeController : BaseApiController
    {
        public EmployeeController(IUnitOfWork uow) : base(uow) {
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var e = _uow.EmployeeRepository.Get(3);
            _uow.EmployeeRepository.Delete(e);
            _uow.Save();
            return _uow.EmployeeRepository.GetAll();
        }
    }
}
