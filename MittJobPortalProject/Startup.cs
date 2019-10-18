using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MittJobPortalProject.Startup))]
namespace MittJobPortalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
