using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GabeHaack.Startup))]
namespace GabeHaack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
