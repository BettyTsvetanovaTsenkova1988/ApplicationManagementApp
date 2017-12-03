using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationManagementApp.Startup))]
namespace ApplicationManagementApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
