using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlagMySpaceWeb.Startup))]
namespace FlagMySpaceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
