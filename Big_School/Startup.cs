using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Big_School.Startup))]
namespace Big_School
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
