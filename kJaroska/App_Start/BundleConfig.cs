using System.Web;
using System.Web.Optimization;

namespace kJaroska
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // JqueryUI
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/themes/base").IncludeDirectory(
                        "~/Content/themes/base", "*.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/DateRangePicker").Include(
                        "~/Content/daterangepicker.css"
                        ));

            bundles.Add(new ScriptBundle("~/Scripts/DataRangePicker").Include(
                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/daterangepicker.js",
                        "~/Scripts/moment.min.js"
                        ));

            // Custom Sorting Scripts
            bundles.Add(new ScriptBundle("~/Scripts/Sorting").Include(
                        "~/Scripts/Sorting.js"));
        }
    }
}
