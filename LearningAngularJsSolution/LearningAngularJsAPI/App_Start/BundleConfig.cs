using System.Web;
using System.Web.Optimization;

namespace LearningAngularJsAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
        
            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Scripts/lib/bootstrap/css/bootstrap.css",
                  "~/Content/main.css"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/lib/modernizr/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/lib/jquery/jquery-{version}.js",
                "~/Scripts/lib/bootstrap/bootstrap.min.js",
                "~/Scripts/lib/angular/angular.js",
                "~/Scripts/lib/angular-ui-router/angular-ui-router.js")

                .IncludeDirectory("~/Scripts/appDir", "*.js", true));
               

            //bundles.Add(new ScriptBundle("~/bundles/myApp"));            

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
