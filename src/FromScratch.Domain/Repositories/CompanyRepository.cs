using FromScratch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FromScratch.Domain.Interfaces;

namespace FromScratch.Domain.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Company> GetByName(string name)
        {
            var companies = _dbContext.Set<Company>()
                .Where(c => c.Name.Contains(name));
            return companies;
        }
    }
}
