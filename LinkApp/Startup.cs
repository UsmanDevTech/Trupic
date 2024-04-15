using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trupic.Startup))]
namespace Trupic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
       
        }
    }
}
