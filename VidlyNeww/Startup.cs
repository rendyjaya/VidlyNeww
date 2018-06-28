using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyNeww.Startup))]
namespace VidlyNeww
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
