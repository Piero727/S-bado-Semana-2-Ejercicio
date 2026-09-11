using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NotHelpingHim : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Func<bool> worth = () => player.Life < 0;
            Console.WriteLine("El mago se enoja con " + player.Name + " por su respuesta.");
            Console.WriteLine("El mago crea un gólem de piedra para que se enfrente a " + player.Name + ".");
            Console.WriteLine(player.Name + " acepta el combate.");
            Enemy enemy = new Enemy("Gólem de piedra", 100, 9);

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
                    Console.WriteLine(player.Name + " a sido derrotado");
                    Console.WriteLine("Game over");
                    return;
                }
            }
            Victory(player, enemy);
        }

        private void Victory(Player player, Enemy enemy)
        {
            Console.WriteLine(enemy.Name + " fue derrotado y el mago también muere porque el gólem le cayó encima.");
            Console.WriteLine(player.Name + " contempla la escena.");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1.- Ignorar la escena.");
            Console.WriteLine("2.- Revivir al mago.");
            Fallprotection();

            while (result < 1 || result > 2)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                Fallprotection();
            }

            switch (result)
            {
                case 1:
                    End_1 end = new End_1();
                    end.BifurcatedHistory(player);
                    break;
                case 2:
                    ReviveTheWizard revive = new ReviveTheWizard();
                    revive.BifurcatedHistory(player);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
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