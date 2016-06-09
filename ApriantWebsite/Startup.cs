using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApriantWebsite.Startup))]
namespace ApriantWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
