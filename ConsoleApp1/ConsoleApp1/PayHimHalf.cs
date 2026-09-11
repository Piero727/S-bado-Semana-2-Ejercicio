using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class PayHimHalf : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Func<bool> worth = () => player.Life < 0;
            Console.WriteLine(player.Name + " le dice que le va a pagar la mitad.");
            Console.WriteLine("El conductor se enoja al oír eso y lo reta a un combate.");
            Console.WriteLine(player.Name + " acepta el combate.");
            Enemy enemy = new Enemy("Conductor", 100, 9);

            Console.WriteLine("Combate:");
            while (enemy.Life > 0)
            {
                Console.WriteLine("Turno de " + player.Name);
                Console.WriteLine("Vida del jugador: " + player.Life);
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1.- Ataque de rocas.");
                Console.WriteLine("2.- Ataque eléctrico.");
                Console.WriteLine("3.- Ataque oscuro.");
                Fallprotection();

                while (result > 3 || result < 1)
                {
                    Console.WriteLine("Solo puedes elegir el 1, el 2 o el 3.");
                    Fallprotection();
                }

                PerformAttack(player, enemy);
                enemy.CausingDamage(player);

                if (worth())
                {
                    Console.WriteLine( player.Name + " a sido derrotado");
                    Console.WriteLine("Game over");
                    return;
                }
            }
            Victory(player, enemy);
        }

        public void Fallprotection()
        {
            try
            {
                result = int.Parse(Console.ReadLine());
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
        }

        private void Victory(Player player, Enemy enemy)
        {
            Console.WriteLine(enemy.Name + " fue derrotado y el autobús volador se quedó sin conductor.");
            Console.WriteLine("Debido a la falta de un conductor, el autobús volador cae del cielo.");
            Console.WriteLine(player.Name + " usa su mapa y se da cuenta de que puede llegar a su parque favorito usando su planeador.");
            Console.WriteLine(player.Name + " se lanza desde el autobús volador para usar su planeador.");
            Console.WriteLine("Al salir, ve cómo el autobús volador se estrella contra una montaña.");
            Console.WriteLine(player.Name + " planea hasta llegar a su destino.");
            End_2 end = new End_2();
            end.BifurcatedHistory(player);
            
        }

        private void PerformAttack(Player player, Enemy enemy)
        {
            switch (result)
            {
                case 1:
                    player.RockAttack(enemy);
                    break;
                case 2:
                    player.ElectricAttack(enemy);
                    break;
                case 3:
                    player.DarkAttack(enemy);
                    break;
                default:
                    Console.WriteLine("Solo tienes ataque de rocas, ataque eléctrico y ataque oscuro");
                    break;
            }
        }
    }
}