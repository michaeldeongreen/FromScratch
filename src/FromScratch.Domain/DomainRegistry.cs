using FromScratch.Domain.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FromScratch.Domain.Infrastructure;

namespace FromScratch.Domain
{
    public class DomainRegistry : Registry
    {
        public DomainRegistry()
        {
            Scan(scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
            For<IDbContext>().Use<DomainDbContext>().Ctor<string>().Is("OrganizationContext");
        }
    }
}
