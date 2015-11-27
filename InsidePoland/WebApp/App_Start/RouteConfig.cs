using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                   name: "ByPolandAspx",
                   url: "ByPoland.aspx",
                   defaults: new { controller = "Home", action = "AboutPoland", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "BNGPolandd",
                   url: "BNGpoland.aspx",
                   defaults: new { controller = "Home", action = "VNGPoland", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                               name: "Bussiness",
                               url: "Business.aspx",
                               defaults: new { controller = "Home", action = "WorkPoland", id = UrlParameter.Optional }
                           );
            routes.MapRoute(
                    name: "cont",
                    url: "Contacts.aspx",
                    defaults: new { controller = "Home", action = "Contacts", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                    name: "Educat",
                    url: "Education.aspx",
                    defaults: new { controller = "Home", action = "EducationPoland", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                    name: "pngpoland",
                    url: "PMGpoland.aspx",
                    defaults: new { controller = "Home", action = "PMGPoland", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                    name: "services",
                    url: "Services.aspx",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                    name: "why",
                    url: "WhyPoland.aspx",
                    defaults: new { controller = "Home", action = "AboutPoland", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller="home", action = "Index", id = UrlParameter.Optional }
            );
            

               
        }
    }
}

