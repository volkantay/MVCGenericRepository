using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGenericRepository.Startup))]
namespace MVCGenericRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
