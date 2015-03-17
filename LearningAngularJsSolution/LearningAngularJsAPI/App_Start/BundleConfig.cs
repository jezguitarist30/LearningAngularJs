using System.Web;
using System.Web.Optimization;

namespace LearningAngularJsAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/app/assets/libs/bootstrap/css/bootstrap.css",
                   "~/app/assets/css/main.css"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/app/assets/libs/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/app/assets/libs/angular/angular.js",
                "~/app/assets/libs/angular-ui-router/angular-ui-router.js"));                  


            bundles.Add(new ScriptBundle("~/bundles/myApp").Include(
                  "~/app/app.js",
                  "~/app/components/views/login/login.js",
                  "~/app/modules/services/LoginService.js",
                  "~/app/modules/constants/UserData.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
