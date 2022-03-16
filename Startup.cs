using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Koolilused.Startup))]
namespace Koolilused
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
