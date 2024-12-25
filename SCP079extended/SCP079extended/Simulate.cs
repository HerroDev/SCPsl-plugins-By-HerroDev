using System;
using Exiled.API.Features;
using CommandSystem;
using PlayerRoles;


// Комманда для симуляции протоколов C.A.S.S.I.E для SCP079
namespace SCP079extended
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Simulate : ICommand
    {
        public string Command => "simulate";

        public string[] Aliases => new string[] {};

        public string Description => "[SCP 079 only] Simulates C.A.S.S.I.E protocols";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender); // полцчаем игрока
            if(player.Role.Type != RoleTypeId.Scp079) // если игрок не 079
            {
                response = "SCP 079 only!";
                return false;
            }
            if(arguments.Count < 1)
            {
                response = "Need arguments! \n1.PB-1\n2.PB-2\n3.PB-3 ЛЗС\n4.PB-3 ТЗС\n5.PL-1\n6.PL-2\n7.PL-3\n8.PL-4\n9.PL-5\n10.PS-2 deactivated\n11.PS-4 deactivated\n12.PS-5 deactivated";
                return false;
            }
            int arg;
            if (!int.TryParse(arguments.At(0), out arg)) // попытка получить аргумент
            {
                response = "Need arguments! \n1.PB-1\n2.PB-2\n3.PB-3 ЛЗС\n4.PB-3 ТЗС\n5.PL-1\n6.PL-2\n7.PL-3\n8.PL-4\n9.PL-5\n10.PS-2 deactivated\n11.PS-4 deactivated\n12.PS-5 deactivated";
                return false;
            }
            switch (arg)
            {
                case 1:
                    Cassie.Message("<color=blue> <size=21>P-B-1 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система <color=blue>герметизации <color=white>заражённых помещений <color=green>активирована<color=white> для избежания дальнейшего <color=red>заражения.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P B 1 status: Activated Attention: The contaminated room sealing system has been activated to prevent further contamination.");
                    break;
                case 2:
                    Cassie.Message("<color=blue> <size=21>P-B-2 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система немедленной чистки комнат при помощи органических <color=green>газов активирована<color=white> для избежания дальнейшего <color=red>заражения.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P B 2 status: Activated Attention: The immediate cleaning system using organic gases has been activated to prevent further contamination.");
                    break;
                case 3:
                    Cassie.Message("<color=blue> <size=21>P-B-3 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система немедленной чистки Лёгкой зоны содержания <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P B 3 status: Activated Attention: The immediate cleaning system for the Light Zone  has been activated. \r\n");
                    break;
                case 4:
                    Cassie.Message("<color=blue> <size=21>P-B-3 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система немедленной чистки <color=blue>Т.З.С.  <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P B 3 status: Activated Attention: The immediate cleaning system for the Heavy Zone  CONTAINMENT  has been activated.");
                    break;
                case 5:
                    Cassie.Message("<color=blue> <size=21>P-L-1 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система блокировки ворот <color=red>А </color>и <color=blue>B</color> для предотвращения входа и выхода из подземной части объекта <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P L 1 status: Activated Attention: The lockdown system for gates A and B to prevent entrance and exit from the underground facility has been activated.");
                    break;
                case 6:
                    Cassie.Message("<color=blue> <size=21>P-L-2 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система <color=red>блокировки <color=blue>контрольно-пропускных </color> <color=white>пунктов <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P L 2 status: Activated Attention: The checkpoint lockdown system has been activated. \r\n");
                    break;
                case 7:
                    Cassie.Message("<color=blue> <size=21>P-L-3 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система блокировки лифтовых систем <color=red>А</color> и <color=blue>B <color=green> активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P L 3 status: Activated Attention: The lockdown system for elevator systems A and B has been activated.");
                    break;
                case 8:
                    Cassie.Message("<color=blue> <size=21>P-L-4 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система блокировки <color=purple>определенной</color> секции или дверей <color=blue>объектов учреждения <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P L 4 status: Activated Attention: The lockdown system for a specific section or doors within the facility has been activated.");
                    break;
                case 9:
                    Cassie.Message("<color=blue> <size=21>P-L-5 </color>Статус: <color=green>Активирован: <split>\r\n<color=red>Внимание:</color> <color=white>система блокировки <color=red>всех <color=yellow>дверей </color> <color=white> учреждения <color=green>активирована.</color> <size=0> pitch_0.2 .g4 .g4 .g3 pitch_1 P L 5 status: Activated Attention: The facility-wide door lockdown system has been activated.");
                    break;
                case 10:
                    Cassie.Message("pitch_0.2 .g4 .g4 .g3 <color=blue> <size=21>P-S-2 </color>Статус: <color=red>Деактивирован: <split>\r\n<color=red>Внимание всему персоналу:</color> <color=white>система отслеживания состояния pitch_100 <color=black>SCP <color=white>объектов <color=red>деактивирована.</color> <size=0>  pitch_1 P S 2 status: Deactivated Attention all personnel: The SCP status tracking system has been deactivated.");
                    break;
                case 11:
                    Cassie.Message("pitch_0.2 .g4 .g4 .g3 <color=blue> <size=21>P-S-4 </color>Статус: <color=red>Деактивирован: <split>\r\n<color=red>Внимание всему персоналу:</color> <color=white>система <color=green>диагностики<color=red> всех <color=white>операций участка, используемая модулем <color=yellow>CASSIE-МДП<color=white>,<color=red> деактивирована.</color> <size=0>  pitch_1 P S 4 status: Deactivated Attention all personnel: The site operation diagnostic system using the CASSIE-MDP module has been deactivated.");
                    break;
                case 12:
                    Cassie.Message("pitch_0.2 .g4 .g4 .g3 <color=blue> <size=21>P-S-5 </color>Статус: <color=red>Деактивирован: <split>\r\n<color=red>Внимание всему персоналу:</color> <color=white>система управления <color=purple>якорями реальности<color=white> в зоне pitch_100 <color=orange>86 <color=red>деактивирована.</color> <size=0>  pitch_1 P S 5 status: Deactivated Attention all personnel: The reality anchor management system in zone 86 has been deactivated.");
                    break;
                default:
                    response = "Need arguments! \n1.PB-1\n2.PB-2\n3.PB-3 ЛЗС\n4.PB-3 ТЗС\n5.PL-1\n6.PL-2\n7.PL-3\n8.PL-4\n9.PL-5\n10.PS-2 deactivated\n11.PS-4 deactivated\n12.PS-5 deactivated";
                    return false;
            }
            response = "You have successfully simulated C.A.S.S.I.E";
            return true;
        }
    }
}
