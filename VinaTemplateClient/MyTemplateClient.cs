using VinaFrameworkClient.Core;
using VinaTemplateClient.Modules;

namespace VinaTemplateClient
{
    public class MyTemplateClient : BaseClient
    {
        public MyTemplateClient()
        {
            AddModule(typeof(PlayerModule));
            AddModule(typeof(VehicleModule));
        }
    }
}
