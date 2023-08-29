using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week6.Startup))]
namespace week6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
