using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UseTheBus : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " va al paradero en donde tomará el autobús.");
            Console.WriteLine(player.Name + " ve el autobús volador acercándose al paradero.");
            Console.WriteLine("El autobús se detiene y " + player.Name + " se sube al vehículo.");

            Console.WriteLine(player.Name + " toma asiento en el autobús.");
            Console.WriteLine("Para no aburrirse, " + player.Name + " observa por la ventana el hermoso paisaje.");
            Console.WriteLine("De pronto, " + player.Name + " se percata de que el autobús volador está cambiando de dirección.");
            Console.WriteLine(player.Name + " se preocupa por la situación y decide hablar con el conductor.");
            Console.WriteLine(player.Name + " le paga la mitad del pasaje al conductor por el desvío.");
            Console.WriteLine("El conductor se enoja con " + player.Name + " y le dice que debe pagar el pasaje completo o enfrentarse a él.");

            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Pagarle.");
            Console.WriteLine("2.- Pagarle la mitad.");

            Fallprotection();
            while (result < 1 || result > 2)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                Fallprotection();
            }

            switch(result)
            {
                case 1:
                    PayHim payHim = new PayHim();
                    payHim.BifurcatedHistory(player);
                    break;
                case 2:
                    PayHimHalf payHimHalf = new PayHimHalf();
                    payHimHalf.BifurcatedHistory(player);
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