using System.Web.Optimization;

namespace WebApplication2
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			#region Scripts
			//Pre defined don't touch!
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

			bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
						"~/Scripts/knockout-3.5.0.js",
						"~/Scripts/knockout-3.5.0.debug.js"));

			//User defined
			bundles.Add(new ScriptBundle("~/Scripts/Login/login").Include(
						"~/Scripts/Login/login.js"));

			bundles.Add(new ScriptBundle("~/Scripts/Register/register").Include(
						"~/Scripts/Register/register.js"));
			#endregion


			#region Styles
			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			bundles.Add(new StyleBundle("~/Content/Login/login").Include(
					  "~/Content/Login/login.css"));

			bundles.Add(new StyleBundle("~/Content/Register/register").Include(
					  "~/Content/Register/register.css"));
			#endregion
		}
	}
}
