using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurfShop.Startup))]
namespace SurfShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
