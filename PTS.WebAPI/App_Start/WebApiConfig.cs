﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PTS.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Enable cross origin resource sharing using Microsoft ASP.NET WebAPI Cors from NuGet
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "PTSAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
