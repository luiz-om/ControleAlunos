using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleAulnos.Startup))]
namespace ControleAulnos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
