using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleWebAppForCICD.Startup))]
namespace SampleWebAppForCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
