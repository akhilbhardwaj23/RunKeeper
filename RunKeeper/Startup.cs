using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunKeeper.Startup))]
namespace RunKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
