using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jqueryObjectLoop.Startup))]
namespace jqueryObjectLoop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			
            ConfigureAuth(app);
        }
    }
}
