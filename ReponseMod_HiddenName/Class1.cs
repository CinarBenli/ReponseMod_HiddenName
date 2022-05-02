using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponseMod_HiddenName
{
    public class Class1 : RocketPlugin<Config>
    {
        protected override void Load()
        {
            base.Load();
            U.Events.OnPlayerConnected += j;
        }

        private void j(UnturnedPlayer player)
        {
            if (player.HasPermission(Configuration.Instance.PolicePerm) || player.HasPermission(Configuration.Instance.DoctorPerm) || player.HasPermission(Configuration.Instance.AdminPerm))
            {
                player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowInteractWithEnemy);
                return;
            }


        }
    }
}
