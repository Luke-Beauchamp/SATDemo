using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATDemo.UI.Startup))]
namespace SATDemo.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
