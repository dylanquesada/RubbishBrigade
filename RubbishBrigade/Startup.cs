using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RubbishBrigade.Startup))]
namespace RubbishBrigade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
