using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GoWalking : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " decide ir caminando hacia su parque favorito.");
            Console.WriteLine("Ha pasado una hora y " + player.Name + " se siente muy cansado. De pronto ve a un mago cerca de un árbol muy colorido.");
            Console.WriteLine("El mago se acerca a " + player.Name + " y le pregunta si ha visto a un gólem dorado.");
            Console.WriteLine(player.Name + " le responde que no lo ha visto.");
            Console.WriteLine("El mago restaura las energías de " + player.Name + " y le pregunta si puede ayudarlo a encontrar a su gólem dorado.");

            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Ayudar al mago.");
            Console.WriteLine("2.- No ayudarlo.");

            Fallprotection();

            while (result < 1 || result > 2)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                Fallprotection();
            }

            switch (result)
            {
                case 1:
                    HelpTheMagician theMagician = new HelpTheMagician();
                    theMagician.BifurcatedHistory(player);
                    break;
                case 2:
                    NotHelpingHim notHelping = new NotHelpingHim();
                    notHelping.BifurcatedHistory(player);
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
