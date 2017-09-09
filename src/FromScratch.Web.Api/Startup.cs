using FromScratch.Web.Api;
using FromScratch.Web.Api.App_Start;
using FromScratch.Web.Api.DependencyResolution;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(Startup))]
namespace FromScratch.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IContainer container = IoC.Initialize();
            HttpConfiguration config = new HttpConfiguration();
            StructuremapMvc.StructureMapDependencyScope = new StructureMapDependencyScope(container);
            DependencyResolver.SetResolver(StructuremapMvc.StructureMapDependencyScope);
            config.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}