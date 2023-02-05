using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_ShopBackend.Startup))]
namespace E_ShopBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
