using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapWebApp.Startup))]
namespace BootStrapWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
