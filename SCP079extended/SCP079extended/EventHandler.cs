﻿using System;
using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp079;
using PlayerRoles;

namespace SCP079extended
{
    public class EventHandler
    {
        public void SpawningPlayerEvent(SpawningEventArgs ev) // Спавн игрока
        {
            if(ev.Player.Role.Type == RoleTypeId.Scp079) // проверка на роль игрока
            {
                Scp079Role scp079 = ev.Player.Role.As<Scp079Role>();
                scp079.Level = 5;
                scp079.AuxManager.CurrentAux = float.MaxValue; // выдали максимальную энергию
            }
        }
        // ИВЕНТЫ ОТКРЫТИЯ ДВЕРЕЙ ОТ SCP 079 И ТД
        public void OnPinging(PingingEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnChangingCamera(ChangingCameraEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnElevatorTeleporting(ElevatorTeleportingEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnGainingExperience(GainingExperienceEventArgs ev) {
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnGainingLevel(GainingLevelEventArgs ev) {
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnInteractingTesla(InteractingTeslaEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnLockingDown(LockingDownEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnRoomBlackout(RoomBlackoutEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnTriggeringDoor(TriggeringDoorEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnZoneBlackout(ZoneBlackoutEventArgs ev) {
            ev.AuxiliaryPowerCost = 0;
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        public void OnChangingSpeakerStatus(ChangingSpeakerStatusEventArgs ev) {
            ev.Scp079.AuxManager.CurrentAux = float.MaxValue; 
        }
        //----------------------------------------------------------------------------------------
    }
}