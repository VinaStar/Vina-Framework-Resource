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
    public class VehicleModule : Module
    {
        public VehicleModule(MyTemplateServer server) : base(server)
        {
            server.AddTick(UpdateProcess);
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
            playerModule = server.GetModule<PlayerModule>();
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
            await Delay(0);
        }

        #endregion
        #region MODULE METHODS



        #endregion
    }
}
