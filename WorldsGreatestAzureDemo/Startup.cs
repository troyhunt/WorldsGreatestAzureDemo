using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldsGreatestAzureDemo.Startup))]
namespace WorldsGreatestAzureDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
