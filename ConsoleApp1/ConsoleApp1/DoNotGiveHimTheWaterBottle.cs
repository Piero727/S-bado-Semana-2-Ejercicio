using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DoNotGiveHimTheWaterBottle : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Func<bool> worth = () => player.Life < 0;
            Console.WriteLine(player.Name + " le dice que no tiene agua.");
            Console.WriteLine("El árbol seco se enoja por la respuesta de " + player.Name + " y le dice que puede leer su mente, descubriendo así su mentira.");
            Console.WriteLine("El árbol seco decide enfrentarse a " + player.Name + ".");
            Enemy enemy = new Enemy("Gran árbol seco", 20, 5);

            Console.WriteLine("Combate:");
            while (enemy.Life > 0 )
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
                    Console.WriteLine(player.Name + " a sido derrotado");
                    Console.WriteLine("Game over");
                    return;
                }
            }

            Victory(player,enemy);
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
            Console.WriteLine(enemy.Name + " fue derrota y el bosque seco comienza a desaparecer");
            Console.WriteLine(player.Name + " sigue su camino.");
            End_1 end = new End_1();
            end.BifurcatedHistory(player);
        }

        private void PerformAttack(Player player, Enemy enemy)
        {
            switch(result)
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
                    Console.WriteLine("Solo tienes ataque de rocas, ataque eléctrico y ataque oscuro.");
                    break;
            }
        }
    }
}