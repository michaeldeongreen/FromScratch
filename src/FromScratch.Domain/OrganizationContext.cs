using FromScratch.Domain.Entities;
using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain
{
    public class OrganizationContext : DbContext, IDbContext
    {
        public OrganizationContext(string connectionString) : base(connectionString) {
        }

        public override int SaveChanges() 
        {
            return base.SaveChanges();
        }
        public override DbSet<TEntity> Set<TEntity>() 
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<OrganizationContext>(new CreateDatabaseIfNotExists<OrganizationContext>());
            //Database.SetInitializer<OrganizationContext>(null);
            modelBuilder.Entity<Company>().ToTable("Company");
            base.OnModelCreating(modelBuilder);
        }
    }
}
