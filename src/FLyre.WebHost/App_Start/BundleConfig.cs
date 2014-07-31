using System.Web;
using System.Web.Optimization;

namespace FLyre.WebHost
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/jqueryval").Include(
                        "~/Scripts/lib/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new Bundle("~/bundles/modernizr").Include(
                        "~/Scripts/lib/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/lib/bootstrap.js",
                      "~/Scripts/lib/respond.js"));

            bundles.Add(new Bundle("~/bundles/angular")
                .Include(new[] { 
                    "~/Scripts/lib/angular.js", 
                    "~/Scripts/lib/angular-route.js", 
                    "~/Scripts/lib/angular-animate.js", 
                    "~/Scripts/lib/angular-resource.js"  
                }));

            bundles.Add(new Bundle("~/bundles/AppMain")
                .Include(new[] { 
                    "~/Scripts/app/FLyre.Routes.js", 
                    "~/Scripts/app/FLyre.js", 
                    "~/Scripts/app/FLyre.Animations.js" 
                }));

            bundles.Add(new Bundle("~/bundles/Controllers").IncludeDirectory("~/Scripts/app/Controllers/", "*.js"));
            bundles.Add(new Bundle("~/bundles/Services").IncludeDirectory("~/Scripts/app/Services/", "*.js"));

            bundles.Add(new StyleBundle("~/Content/cssbase").Include(
                      "~/Content/css/lib/bootstrap.css",
                      "~/Content/css/app/Shell.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}