using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Groupware.AdventureWorks.Demo.Startup))]
namespace Groupware.AdventureWorks.Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
