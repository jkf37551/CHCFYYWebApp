using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHCFYYWebApp.Startup))]
namespace CHCFYYWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
