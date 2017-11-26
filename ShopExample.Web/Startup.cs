using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopExample.Web.Startup))]
namespace ShopExample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
