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
    public class PlayerModule : Module
    {
        public PlayerModule(Client client) : base(client)
        {
            script.AddTick(UpdateProcess);
        }

        #region MODULES

        private VehicleModule vehicleModule;

        #endregion
        #region ACCESSORS



        #endregion
        #region VARIABLES



        #endregion
        #region BASE EVENTS

        protected override void OnModuleInitialized()
        {
            vehicleModule = client.GetModule<VehicleModule>();
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
