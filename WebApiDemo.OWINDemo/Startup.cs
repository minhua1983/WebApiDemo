using System;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApiDemo.OWINDemo.Startup))]

namespace WebApiDemo.OWINDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            app.UseWebApi(config);
        }
    }
}
