using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeStore.NetAssissns.Startup))]
namespace BikeStore.NetAssissns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
