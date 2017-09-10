using FromScratch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FromScratch.Domain.Interfaces;

namespace FromScratch.Domain.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
