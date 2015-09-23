using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDS.Website.Startup))]
namespace TDS.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
