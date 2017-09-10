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
    public class CompanyController : BaseApiController
    {
        public CompanyController(IUnitOfWork uow) : base(uow)
        {
            _uow.CompanyRepository.Add(new Company()
            {
                Name = "Litecoin",
                Employees = new List<Employee>() { new Employee() { FirstName = "Charlie", LastName = "Lee" } }
            });
            _uow.LogRepository.Add(new Log() { Description = "Inserted a new Company into the database." });
            _uow.Save();
        }

        [HttpGet]
        public IEnumerable<Company> Get()
        {
            var companies = _uow.CompanyRepository.GetByName("gren");
            var companies1 = _uow.CompanyRepository.Find(c => c.Name.Contains("erk"));
            return companies1;
            //return _uow.CompanyRepository.GetAll();
        }
    }
}
