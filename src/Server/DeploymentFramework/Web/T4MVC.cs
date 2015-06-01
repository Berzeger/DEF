﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
using Baud.Deployment.Web.Framework.Security;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly SecurityClass s_Security = new SecurityClass();
    public static SecurityClass SecurityArea { get { return s_Security; } }
    public static Baud.Deployment.Web.Controllers.AccountController Account = new Baud.Deployment.Web.Controllers.T4MVC_AccountController();
    public static Baud.Deployment.Web.Controllers.HomeController Home = new Baud.Deployment.Web.Controllers.T4MVC_HomeController();
    public static Baud.Deployment.Web.Controllers.ManageController Manage = new Baud.Deployment.Web.Controllers.T4MVC_ManageController();
    public static Baud.Deployment.Web.Controllers.PackagesController Packages = new Baud.Deployment.Web.Controllers.T4MVC_PackagesController();
    public static Baud.Deployment.Web.Controllers.ProductsController Products = new Baud.Deployment.Web.Controllers.T4MVC_ProductsController();
    public static Baud.Deployment.Web.Controllers.ServersController Servers = new Baud.Deployment.Web.Controllers.T4MVC_ServersController();
    public static T4MVC.SecurityController Security = new T4MVC.SecurityController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class SecurityClass
    {
        public readonly string Name = "Security";
        public Baud.Deployment.Web.Areas.Security.Controllers.UsersController Users = new Baud.Deployment.Web.Areas.Security.Controllers.T4MVC_UsersController();
        public T4MVC.Security.SharedController Shared = new T4MVC.Security.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult, IRequiresPermission
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public string RequiredPermission { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_bundle_min_js = Url("bootstrap-bundle.min.js");
        public static readonly string jquery_bundle_min_js = Url("jquery-bundle.min.js");
        public static readonly string jquery_validate_unobtrusive_chameleon_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.chameleon.min.js") ? Url("jquery.validate.unobtrusive.chameleon.min.js") : Url("jquery.validate.unobtrusive.chameleon.js");
        public static readonly string modernizer_min_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizer-min.min.js") ? Url("modernizer-min.min.js") : Url("modernizer-min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class dist {
            private const string URLPATH = "~/Content/dist";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class css {
                private const string URLPATH = "~/Content/dist/css";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string app_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/app.min.css") ? Url("app.min.css") : Url("app.css");
                        public static readonly string app_min_css = Url("app.min.css");
            }
        
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
                }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


