using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectFinale.Startup))]
namespace ProjectFinale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
