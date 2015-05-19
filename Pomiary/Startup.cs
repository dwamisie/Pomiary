using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pomiary.Startup))]
namespace Pomiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
