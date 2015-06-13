using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Parse;

namespace FlagMySpaceWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ParseClient.Initialize("0CfufDW1fVFTkeXQqrFPbhygiRmtxtiznMqDEtxS", "eJboXzCTv3wpx7y9cWglDbFYNZC4kB1FNUbx9tAf");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
