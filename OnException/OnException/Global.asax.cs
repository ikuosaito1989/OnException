using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OnException
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Application_Error発生
            //throw new Exception("Application_BeginRequest");
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Console.WriteLine("Application_Error");
            Server.ClearError();
            Server.Transfer("/Error");
            return;
        }
    }
}
