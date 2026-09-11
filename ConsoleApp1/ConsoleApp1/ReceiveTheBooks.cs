using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReceiveTheBooks : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " recibió los 4 libros de hechicería avanzada.");
            player.AddContent("Fundamentos de la magia avanzada");
            player.AddContent("Magia 21");
            player.AddContent("El poder de la magia no mortal");
            player.AddContent("Magia y sus matices");
            player.ShowContent();

            Console.WriteLine(player.Name + " le agradece al mago y sigue su camino.");
            End_1 end = new End_1();
            end.BifurcatedHistory(player);
        }
    }
}
