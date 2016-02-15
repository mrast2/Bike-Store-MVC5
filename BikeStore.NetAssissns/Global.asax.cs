using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BikeStore.NetAssissns
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(new BikeStore.NetAssissns.Models.SampleData());
            new BikeStore.NetAssissns.Models.BikeStoreEntities().Database.Initialize(false);
            //System.Data.Entity.Database.SetInitializer(new BikeStore.NetAssissns.Models.ApplicationDbConfiguration());
            //new BikeStore.NetAssissns.Models.ApplicationDbContext().Database.Initialize(false);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
