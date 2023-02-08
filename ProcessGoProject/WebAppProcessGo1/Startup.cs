using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProcessGo1.Startup))]
namespace WebAppProcessGo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
