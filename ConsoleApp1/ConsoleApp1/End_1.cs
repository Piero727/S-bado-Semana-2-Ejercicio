using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class End_1 : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine("Después de un largo camino, " + player.Name + " llega a su destino.");
            Console.WriteLine(player.Name + " se sienta en el suelo y admira la gran belleza de su parque favorito.");
            Console.WriteLine("Fin");
        }
    }
}
