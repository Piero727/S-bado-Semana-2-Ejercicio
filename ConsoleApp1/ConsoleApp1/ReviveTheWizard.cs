using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReviveTheWizard : History, TryCatch
    {
        private int result;
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " decide revivir al mago usando toda su magia.");
            Console.WriteLine("El mago revive, agradece a " + player.Name + " por devolverle la vida y quiere regalarle 4 libros de hechicería avanzada.");
            Console.WriteLine(player.Name + " está pensando en aceptar los libros o no.");
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1.- Recibir los libros");
            Console.WriteLine("2.- No recibir los libros");
            Fallprotection();

            while (result < 1 || result > 2)
            {
                Console.WriteLine("Solo puedes elegir el 1 o el 2.");
                Fallprotection();
            }

            switch (result)
            {
                case 1:
                    ReceiveTheBooks theBooks = new ReceiveTheBooks();
                    theBooks.BifurcatedHistory(player);
                    break;
                case 2:
                    NotReceivingTheBooks notReceivingTheBooks = new NotReceivingTheBooks();
                    notReceivingTheBooks.BifurcatedHistory(player);
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
