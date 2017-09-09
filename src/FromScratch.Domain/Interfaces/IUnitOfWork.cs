using FromScratch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICompanyRepository CompanyRepository{ get; }
        int Save();
    }
}
