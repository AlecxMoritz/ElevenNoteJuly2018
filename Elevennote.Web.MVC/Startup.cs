using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elevennote.Web.MVC.Startup))]
namespace Elevennote.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
