using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using CitizenFX.Core.Native;

using VinaFrameworkClient.Core;

namespace VinaTemplateClient.Modules
{
    public class VehicleModule : Module
    {
        public VehicleModule(BaseClient client) : base(client)
        {
            script.AddTick(UpdateProcess);
        }

        #region MODULES

        private PlayerModule playerModule;

        #endregion
        #region ACCESSORS



        #endregion
        #region VARIABLES



        #endregion
        #region BASE EVENTS

        protected override void OnModuleInitialized()
        {
            playerModule = client.GetModule<PlayerModule>();
        }

        #endregion
        #region MODULE EVENTS



        #endregion
        #region MODULE TICKS

        private async Task UpdateProcess()
        {
            await Client.Delay(0);
        }

        #endregion
        #region MODULE METHODS



        #endregion
    }
}
