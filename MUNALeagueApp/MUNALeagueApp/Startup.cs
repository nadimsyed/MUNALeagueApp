using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MUNALeagueApp.Startup))]
namespace MUNALeagueApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
