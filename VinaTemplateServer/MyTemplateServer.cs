using VinaFrameworkServer.Core;
using VinaTemplateServer.Modules;

namespace VinaTemplateServer
{
    public class MyTemplateServer : BaseServer
    {
        public MyTemplateServer()
        {
            AddModule(typeof(PlayerModule));
            AddModule(typeof(VehicleModule));
        }
    }
}
