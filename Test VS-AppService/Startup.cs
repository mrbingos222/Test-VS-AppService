using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_VS_AppService.Startup))]
namespace Test_VS_AppService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
