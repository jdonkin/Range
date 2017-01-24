using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Range.Startup))]
namespace Range
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
