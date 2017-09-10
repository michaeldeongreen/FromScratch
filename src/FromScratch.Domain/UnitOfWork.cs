using FromScratch.Domain.Interfaces;
using FromScratch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private ILogRepository _logRepository;
        public ICompanyRepository CompanyRepository { get { return _companyRepository = _companyRepository ?? new CompanyRepository(_dbContext); } }
        public IEmployeeRepository EmployeeRepository { get { return _employeeRepository = _employeeRepository ?? new EmployeeRepository(_dbContext); } }
        public ILogRepository LogRepository { get { return _logRepository = _logRepository ?? new LogRepository(_dbContext); } }
        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
