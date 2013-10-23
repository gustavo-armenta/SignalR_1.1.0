using Microsoft.AspNet.SignalR.Samples.Raw;
using Microsoft.AspNet.SignalR.Server;
using Microsoft.Owin;
using Owin;

namespace Microsoft.AspNet.SignalR.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapConnection<RawConnection>("/raw", new ConnectionConfiguration { EnableCrossDomain = true });
            app.MapHubs(new HubConfiguration { EnableCrossDomain = true });
        }
    }
}
