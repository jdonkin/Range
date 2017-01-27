using System.Web;
using System.Web.Optimization;

namespace Range
{
  public class BundleConfig
  {
    private const string AngularBundle = "~/bundles/angular";
    private const string AngularLocation = "~/Scripts/angular.js";
    private const string AngularRoute = "~/Scripts/angular-route.js";
    private const string AngularApp = "~/Scripts/app.js";
    private const string ControllerPath = "~/Scripts/Controller";
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

      bundles.Add(new ScriptBundle(AngularBundle).Include(AngularLocation, AngularRoute, AngularApp).IncludeDirectory(ControllerPath, "*.js"));

    }
  }
}
