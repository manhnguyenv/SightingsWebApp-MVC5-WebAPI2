using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SightingsWebAPI2.Startup))]
namespace SightingsWebAPI2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
