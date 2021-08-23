using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HongMang.Startup))]
namespace HongMang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
