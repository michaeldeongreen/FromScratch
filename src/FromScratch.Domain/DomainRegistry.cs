using FromScratch.Domain.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            For<IDbContext>().Use<OrganizationContext>().Ctor<string>().Is("OrganizationContext");
        }
    }
}
