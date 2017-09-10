using FromScratch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain.Infrastructure
{
    internal class DomainMap
    {
        private readonly DbModelBuilder _modelBuilder;
        public DomainMap(DbModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void MapEntities()
        {
            MapCompany();
            MapEmployee();
            MapLog();
        }

        private void MapCompany()
        {
            _modelBuilder.Entity<Company>().ToTable("Company");
        }
        private void MapEmployee()
        {
            
            _modelBuilder.Entity<Employee>().ToTable("Employee")
                .HasRequired(e => e.Company)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.CompanyId);
        }
        private void MapLog()
        {
            _modelBuilder.Entity<Log>().ToTable("Log");
        }
    }
}
