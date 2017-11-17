using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Tulpep.MailgunProxy
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var corsAttributes = new EnableCorsAttribute(ConfigurationManager.AppSettings[Constants.CORSOrigins], ConfigurationManager.AppSettings[Constants.CORSHeaders], ConfigurationManager.AppSettings[Constants.CORSMethods]);
            config.EnableCors(corsAttributes);

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
