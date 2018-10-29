using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFinanceWeb.Startup))]
namespace MyFinanceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
