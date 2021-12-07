using Unity;
using Unity.WebApi;
using System.Web.Http;

using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using FreshersApp.Data.Repositories;
using FreshersApp.Business.Managers;
using FreshersApp.Data.Interface;
using FreshersApp.Business.Interface;

namespace FreshersApp.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var container = new UnityContainer();

            // Regestering the Interfaces and class for unit dependency injuction
            
            container.RegisterType<IMasterRepository, MasterRepository>();
            container.RegisterType<IMasterManager, MasterManager>();

            //container.RegisterType<IVendorRepository,VendorRepository>();
            //container.RegisterType<IVendorManager, VendorManager>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            config.DependencyResolver = new UnityDependencyResolver(container);
           

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
