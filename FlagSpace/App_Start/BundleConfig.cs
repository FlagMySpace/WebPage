using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FlagSpace.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //orser of css or js
            //1. Jquery
            //2. Bootstrap
            #region JS / SCRIPT

            bundles.Add(new ScriptBundle("~/bundles/jQuery").Include(
                "~/Scripts/jquery-2.1.3.js"
                //"~/Scripts/jquery-2.1.3.intellisense.js", 
                //"~/Scripts/bootstrap.js"
                , "~/Scripts/bootstrap.min.js"
                , "~/Scripts/jquery.easing.min.js"
                , "~/Scripts/scrolling-nav.js"                
                ));

            #endregion

            #region CSS / STYLE

            bundles.Add(new StyleBundle("~/bundles/BootstrapCss").Include(
                //"~/Content/bootstrap.css"
                //, "~/Content/bootstrap-theme.css"
                "~/Content/bootstrap.min.css"
                , "~/Content/scrolling-nav.css"
                ));
            #endregion

            // Enable bundle optimization.
            BundleTable.EnableOptimizations = true;

        }
    }
}