using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnuesseTool.Startup))]
namespace KnuesseTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
