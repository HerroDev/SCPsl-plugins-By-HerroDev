using System;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace SCP079extended
{
    public class Plugin : Plugin<Config>
    {
        public EventHandler eventHandler; // Создаем обьект обработчика событий
        public SubscribeEvents subscribeEvents;
        public override void OnEnabled() // Включение плагина
        {
            base.OnEnabled();
            eventHandler = new EventHandler();
            subscribeEvents = new SubscribeEvents(this);

            subscribeEvents.RegisterEvent(true);
        }
        public override void OnDisabled() // Выключение плагина
        {
            base.OnDisabled();
            eventHandler = null;
            subscribeEvents = null;
            subscribeEvents.RegisterEvent(false);
        }
    }
}
