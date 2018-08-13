using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Patment.Startup))]
namespace Patment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
