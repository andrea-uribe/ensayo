using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ensayo.Startup))]
namespace ensayo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
