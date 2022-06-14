using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubMvc.Startup))]
namespace GitHubMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
