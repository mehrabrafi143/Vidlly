using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlly.Startup))]
namespace Vidlly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
