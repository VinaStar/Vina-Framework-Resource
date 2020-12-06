using VinaFrameworkClient.Core;
using VinaTemplateClient.Modules;

namespace VinaTemplateClient
{
    public class Client : BaseClient
    {
        public Client()
        {
            AddModule(typeof(BasicModule));
        }
    }
}
