using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabTH.Startup))]
namespace LabTH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
