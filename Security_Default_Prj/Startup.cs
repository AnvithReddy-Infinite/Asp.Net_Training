using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security_Default_Prj.Startup))]
namespace Security_Default_Prj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
