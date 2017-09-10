using FromScratch.Domain.Entities;
using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FromScratch.Domain.Infrastructure;

namespace FromScratch.Domain.Repositories
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        public LogRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
