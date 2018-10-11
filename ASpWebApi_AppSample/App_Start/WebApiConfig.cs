using System;
using System.Web.Http;
using Microsoft.OData.Edm;
using System.Net.Http.Headers;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using ASpWebApi_AppSample.Models;




namespace ASpWebApi_AppSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.MapODataServiceRoute("oDataRouting", "odata", GetEdmModel());
        }

        //private static IEdmModel GetEdmModel()
        //{
        //    var builder = new ODataConventionModelBuilder();
        //    builder.EntitySet<Car>("Cars");
        //    var edmModel = builder.GetEdmModel();
        //    return edmModel;
        //}
    }
}
