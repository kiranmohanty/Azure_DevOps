using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Redbus.Startup))]
namespace Redbus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
