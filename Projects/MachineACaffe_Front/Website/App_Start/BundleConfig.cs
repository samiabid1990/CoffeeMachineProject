using System.Web;
using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                      "~/Scripts/Jquery/jquery-3.2.1.js",
                      "~/Scripts/Angular/angular.js",
                      "~/Scripts/Angular-material/angular-animate.js",
                      "~/Scripts/Angular-material/angular-aria.js",
                      "~/Scripts/Angular-material/angular-material.js",
                      "~/Scripts/Angular-material/angular-messages.js",
                      "~/App/Global.js"));

            bundles.Add(new StyleBundle("~/Styles").Include(
                      "~/Styles/angular-material.css",
                      "~/Styles/style.css"));
        }
    }
}
