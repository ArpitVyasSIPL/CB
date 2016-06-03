using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CB.Startup))]
namespace CB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
