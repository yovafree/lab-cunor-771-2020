using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcEjemplo3.Startup))]
namespace mvcEjemplo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
