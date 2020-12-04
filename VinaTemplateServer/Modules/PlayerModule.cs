using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using CitizenFX.Core.Native;

using VinaFrameworkServer.Core;

namespace VinaTemplateServer.Modules
{
    public class PlayerModule : Module
    {
        public PlayerModule(Server server) : base(server)
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
            vehicleModule = server.GetModule<VehicleModule>();
        }

        protected override void OnPlayerConnecting(Player player)
        {

        }

        protected override void OnPlayerDropped(Player player, string reason)
        {

        }

        protected override void OnPlayerClientInitialized(Player player)
        {

        }

        #endregion
        #region MODULE EVENTS



        #endregion
        #region MODULE TICKS

        private async Task UpdateProcess()
        {
            await Server.Delay(0);
        }

        #endregion
        #region MODULE METHODS



        #endregion
    }
}
