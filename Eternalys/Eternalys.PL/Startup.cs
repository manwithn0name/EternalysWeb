using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eternalys.PL.Startup))]
namespace Eternalys.PL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
