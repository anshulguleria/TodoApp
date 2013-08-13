using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ToDoApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AccountApi",
                routeTemplate: "{userName}/{action}/{id}",
                defaults: new { controller = "Account", action = RouteParameter.Optional, id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "AdminApi",
                routeTemplate: "Admin/{userName}",
                defaults: new { controller = "Account", action = "Home", role = "Administrator", id = RouteParameter.Optional }
            );
            config.EnableSystemDiagnosticsTracing();
        }
    }
}
