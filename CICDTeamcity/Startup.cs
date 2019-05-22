using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICDTeamcity.Startup))]
namespace CICDTeamcity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
