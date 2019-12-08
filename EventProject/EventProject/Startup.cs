using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventProject.Startup))]
namespace EventProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
