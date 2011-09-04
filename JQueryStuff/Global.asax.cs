using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JQueryStuff
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "fadingroute", // Route name
               "fading", // URL with parameters
               new { controller = "Home", action = "Fading", id = UrlParameter.Optional } // Parameter defaults
           );
            routes.MapRoute("slidingroute", "sliding",new { controller = "Home", action = "SlidingPage", id = UrlParameter.Optional });
            routes.MapRoute("leftslideroute", "left",new { controller = "Home", action = "Left", id = UrlParameter.Optional });
            routes.MapRoute("rightslideroute", "right",new { controller = "Home", action = "Right", id = UrlParameter.Optional });
            routes.MapRoute("modalslideroute", "modal",new { controller = "Home", action = "Modal", id = UrlParameter.Optional });
            routes.MapRoute("textroute", "text",new { controller = "Home", action = "Font", id = UrlParameter.Optional });
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}