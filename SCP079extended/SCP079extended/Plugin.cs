using System;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace SCP079extended
{
    public class Plugin : Plugin<Config>
    {
        public EventHandler eventHandler; // Создаем обьект обработчика событий
        public override void OnEnabled() // Включение плагина
        {
            base.OnEnabled();
            eventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.Spawning += eventHandler.SpawningPlayerEvent; // Отправляем в обработчик ивент
            // Ивенты от scp 079
            Exiled.Events.Handlers.Scp079.Pinging += eventHandler.OnPinging;
            Exiled.Events.Handlers.Scp079.ChangingCamera += eventHandler.OnChangingCamera;
            Exiled.Events.Handlers.Scp079.ElevatorTeleporting += eventHandler.OnElevatorTeleporting;
            Exiled.Events.Handlers.Scp079.GainingExperience += eventHandler.OnGainingExperience;
            Exiled.Events.Handlers.Scp079.GainingLevel += eventHandler.OnGainingLevel;
            Exiled.Events.Handlers.Scp079.InteractingTesla += eventHandler.OnInteractingTesla;
            Exiled.Events.Handlers.Scp079.LockingDown += eventHandler.OnLockingDown;
            Exiled.Events.Handlers.Scp079.RoomBlackout += eventHandler.OnRoomBlackout;
            Exiled.Events.Handlers.Scp079.TriggeringDoor += eventHandler.OnTriggeringDoor;
            Exiled.Events.Handlers.Scp079.ZoneBlackout += eventHandler.OnZoneBlackout;
            Exiled.Events.Handlers.Scp079.ChangingSpeakerStatus += eventHandler.OnChangingSpeakerStatus;
            //------------------------------------------------------------------------------------
        }
        public override void OnDisabled() // Выключение плагина
        {
            base.OnDisabled();
            eventHandler = null;
            Exiled.Events.Handlers.Player.Spawning -= eventHandler.SpawningPlayerEvent; // Отправляем в обработчик ивент
        }
    }
}
