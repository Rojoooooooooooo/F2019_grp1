﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PetParadise.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/jquery-ui.css",
                 "~/Content/jquery-ui.theme.css",
                 "~/Content/jquery-ui.structure.css",
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css",
                 "~/Content/fontawesome.css"));

            // My custom scripts

            bundles.Add(new ScriptBundle("~/bundles/helpers").Include(
                "~/Scripts/access.js",
                "~/Scripts/ValidationHandler/Validator.js",
                "~/Scripts/ValidationHandler/InvalidObject.js"));

            //the following creates bundles in debug mode;
            BundleTable.EnableOptimizations = true;
        }
    }
}