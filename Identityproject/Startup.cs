using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identityproject.Startup))]
namespace Identityproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
