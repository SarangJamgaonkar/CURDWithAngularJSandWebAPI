﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace CURDWithAngularJSandWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "GetAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "employee", action = "GetAllEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "AddAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "employee", action = "AddEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "GetSingleAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "employee", action = "GetEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "UpdateAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "employee", action = "UpdateEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "DeleteAPI",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "employee", action = "DeleteEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
