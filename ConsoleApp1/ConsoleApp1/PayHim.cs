using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PayHim : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " le paga al conductor los 2 soles y lo deja en el paradero más cercano.");
            player.Money -= 2;
            Console.WriteLine("Dinero restante: " + player.Money + " soles.");
            Console.WriteLine("Al bajarse del autobús volador, " + player.Name + " decide sacar su mapa para ir a su parque favorito y así comienza el camino hacia su destino.");
            Console.WriteLine(player.Name + " pasa por un bosque seco y a lo lejos ve un gran árbol seco y triste.");
            Console.WriteLine(player.Name + " se acerca al gran árbol seco y le pregunta por qué está triste.");
            Console.WriteLine("El árbol le responde que tiene mucha sed.");
            Console.WriteLine("Al escuchar su tragedia, " + player.Name + " recuerda que tiene una botella con agua en su inventario mágico.");
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Darle la botella con agua.");
            Console.WriteLine("2.- No darle la botella con agua.");
            Fallprotection();

            while (result < 1 || result > 2)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                Fallprotection();
            }

            switch (result)
            {
                case 1:
                    BottleWithWater withWater = new BottleWithWater();
                    withWater.BifurcatedHistory(player);
                    break;

                case 2:
                    DoNotGiveHimTheWaterBottle theWaterBottle = new DoNotGiveHimTheWaterBottle();
                    theWaterBottle.BifurcatedHistory(player);
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
    }
}