using VinaFrameworkServer.Core;
using VinaTemplateServer.Modules;

namespace VinaTemplateServer
{
    public class Server : BaseServer
    {
        public Server()
        {
            AddModule(typeof(PlayerModule));
            AddModule(typeof(VehicleModule));
        }
    }
}
