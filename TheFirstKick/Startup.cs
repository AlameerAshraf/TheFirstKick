using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheFirstKick.Startup))]
namespace TheFirstKick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
