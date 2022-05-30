using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamQuangLong_1911067466_LAB456.Startup))]
namespace PhamQuangLong_1911067466_LAB456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
