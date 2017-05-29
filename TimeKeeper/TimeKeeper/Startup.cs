using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeKeeper.Startup))]
namespace TimeKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
