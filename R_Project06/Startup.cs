using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(R_Project06.Startup))]
namespace R_Project06
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
