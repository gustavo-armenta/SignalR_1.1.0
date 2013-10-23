using System;
using System.Web.Routing;
using Microsoft.AspNet.SignalR.Samples.Raw;

namespace Microsoft.AspNet.SignalR.Server.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapConnection<RawConnection>("/raw", "/raw", new ConnectionConfiguration { EnableCrossDomain = true });
            RouteTable.Routes.MapHubs(new HubConfiguration { EnableCrossDomain = true });
        }
    }
}