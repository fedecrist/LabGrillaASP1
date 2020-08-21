using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabGrillaASP1.Startup))]
namespace LabGrillaASP1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
