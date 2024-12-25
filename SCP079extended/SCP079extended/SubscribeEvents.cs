using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP079extended
{
    public class SubscribeEvents
    {
        private Plugin plugin;
        public SubscribeEvents(Plugin plugin) => this.plugin = plugin;
        public void RegisterEvent(bool enabled = true)
        {
            if(enabled)
            {
                Exiled.Events.Handlers.Player.Spawning += plugin.eventHandler.SpawningPlayerEvent;  // Спавн игрока
                //--------------------------------SCP 079--------------------------------
                Exiled.Events.Handlers.Scp079.Pinging += plugin.eventHandler.OnPinging;
                Exiled.Events.Handlers.Scp079.ChangingCamera += plugin.eventHandler.OnChangingCamera;
                Exiled.Events.Handlers.Scp079.ElevatorTeleporting += plugin.eventHandler.OnElevatorTeleporting;
                Exiled.Events.Handlers.Scp079.GainingExperience += plugin.eventHandler.OnGainingExperience;
                Exiled.Events.Handlers.Scp079.GainingLevel += plugin.eventHandler.OnGainingLevel;
                Exiled.Events.Handlers.Scp079.InteractingTesla += plugin.eventHandler.OnInteractingTesla;
                Exiled.Events.Handlers.Scp079.LockingDown += plugin.eventHandler.OnLockingDown;
                Exiled.Events.Handlers.Scp079.RoomBlackout += plugin.eventHandler.OnRoomBlackout;
                Exiled.Events.Handlers.Scp079.TriggeringDoor += plugin.eventHandler.OnTriggeringDoor;
                Exiled.Events.Handlers.Scp079.ZoneBlackout += plugin.eventHandler.OnZoneBlackout;
                Exiled.Events.Handlers.Scp079.ChangingSpeakerStatus += plugin.eventHandler.OnChangingSpeakerStatus;
            } else
            {
                Exiled.Events.Handlers.Player.Spawning -= plugin.eventHandler.SpawningPlayerEvent;  // Спавн игрока
                //--------------------------------SCP 079--------------------------------
                Exiled.Events.Handlers.Scp079.Pinging -= plugin.eventHandler.OnPinging;
                Exiled.Events.Handlers.Scp079.ChangingCamera -= plugin.eventHandler.OnChangingCamera;
                Exiled.Events.Handlers.Scp079.ElevatorTeleporting -= plugin.eventHandler.OnElevatorTeleporting;
                Exiled.Events.Handlers.Scp079.GainingExperience -= plugin.eventHandler.OnGainingExperience;
                Exiled.Events.Handlers.Scp079.GainingLevel -= plugin.eventHandler.OnGainingLevel;
                Exiled.Events.Handlers.Scp079.InteractingTesla -= plugin.eventHandler.OnInteractingTesla;
                Exiled.Events.Handlers.Scp079.LockingDown -= plugin.eventHandler.OnLockingDown;
                Exiled.Events.Handlers.Scp079.RoomBlackout -= plugin.eventHandler.OnRoomBlackout;
                Exiled.Events.Handlers.Scp079.TriggeringDoor -= plugin.eventHandler.OnTriggeringDoor;
                Exiled.Events.Handlers.Scp079.ZoneBlackout -= plugin.eventHandler.OnZoneBlackout;
                Exiled.Events.Handlers.Scp079.ChangingSpeakerStatus -= plugin.eventHandler.OnChangingSpeakerStatus;
            }
        }
    }
}
