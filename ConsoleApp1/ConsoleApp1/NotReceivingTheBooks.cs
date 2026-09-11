using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NotReceivingTheBooks : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " rechaza el regalo del mago.");
            Console.WriteLine("El mago acepta la decisión de " + player.Name + ".");
            Console.WriteLine(player.Name + " se despide del mago y sigue su camino.");
            End_1 end = new End_1();
            end.BifurcatedHistory(player);
        }
    }
}
