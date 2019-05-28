using System.Web;
using System.Web.Optimization;

namespace Daycoval.DayBot.Presentation.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
                      "~/Content/fullcalendar/core/main.js",
                      "~/Content/fullcalendar/interaction/main.js",
                      "~/Content/fullcalendar/core/locales/pt-br.js",
                      "~/Content/fullcalendar/daygrid/main.js",
                      "~/Content/fullcalendar/timegrid/main.js",
                      "~/Content/fullcalendar/list/main.js",
                      "~/Scripts/fullcalendar/init.js"));

            bundles.Add(new StyleBundle("~/Content/css/fullcalendar").Include(
                      "~/Content/fullcalendar/core/main.css",
                      "~/Content/fullcalendar/daygrid/main.css",
                      "~/Content/fullcalendar/timegrid/main.css",
                      "~/Content/fullcalendar/list/main.css"));

        }
    }
}
