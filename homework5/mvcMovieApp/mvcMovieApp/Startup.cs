using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMovieApp.Startup))]
namespace mvcMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
