using Owin;
using WebApi2ExtAuth.App_Start;

namespace WebApi2ExtAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SecurityConfig.Configure(app);
            WebApiConfig.Configure(app);
        }
    }
}