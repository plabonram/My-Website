using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlabonModak.Startup))]
namespace PlabonModak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
