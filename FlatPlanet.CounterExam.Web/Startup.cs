using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlatPlanet.CounterExam.Web.Startup))]
namespace FlatPlanet.CounterExam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
