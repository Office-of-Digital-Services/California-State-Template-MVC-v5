﻿using System.Web;
using System.Web.Optimization;

namespace StateTemplateV5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/stateTemplateLibJs").Include(
                     "~/Content/StateTemplate/js/libs/jquery.min.js",
                     "~/Content/StateTemplate/js/libs/jquery-migrate.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/stateTemplateJs").Include(
                     "~/Content/StateTemplate/js/cagov.core.min.js",
                     "~/Content/StateTemplate/js/search.js"));

            bundles.Add(new StyleBundle("~/Content/stateTemplateCss").Include(
                      "~/Content/StateTemplate/css/cagov.core.min.css",
                      "~/Content/StateTemplate/css/colorscheme-oceanside.min.css",
                      "~/Content/site.css"));
        }
    }
}
