using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRchat.Startup))]
namespace SignalRchat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
