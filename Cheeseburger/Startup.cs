using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cheeseburger.Startup))]
namespace Cheeseburger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
