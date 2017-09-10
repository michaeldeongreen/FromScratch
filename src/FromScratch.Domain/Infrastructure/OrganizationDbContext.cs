using FromScratch.Domain.Entities;
using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain.Infrastructure
{
    public class OrganizationDbContext : DbContext, IDbContext
    {
        public OrganizationDbContext(string connectionString) : base(connectionString) {
        }

        public override int SaveChanges() 
        {
            return base.SaveChanges();
        }
        public override DbSet<TEntity> Set<TEntity>() 
        {
            return base.Set<TEntity>();
        }

        public new DbEntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<OrganizationDbContext>(new CreateDatabaseIfNotExists<OrganizationDbContext>());
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Employee>().ToTable("Employee")
                .HasRequired(e => e.Company)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.CompanyId);
            modelBuilder.Entity<Log>().ToTable("Log");
        }
    }
}
