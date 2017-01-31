using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Voice_Maate.Startup))]
namespace Voice_Maate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
