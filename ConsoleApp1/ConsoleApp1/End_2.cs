using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class End_2 : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine("Después de un largo camino planeando, " + player.Name + " llega a su destino.");
            Console.WriteLine(player.Name + " aterriza cerca de un bello lago y se sienta en el suelo para admirar el paisaje.");
            Console.WriteLine("Fin");
        }
    }
}
