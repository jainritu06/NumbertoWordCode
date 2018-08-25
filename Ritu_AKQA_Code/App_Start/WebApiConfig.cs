
using System.Web.Http;
using Ritu_AKQA_Code.Repository;
using Ritu_AKQA_Code.Resolver;
using Unity;
using Unity.Lifetime;

namespace Ritu_AKQA_Code
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services 
            var container = new UnityContainer();
            container.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes 
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

    }
}
