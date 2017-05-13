using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullMVC.Startup))]
namespace FullMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
