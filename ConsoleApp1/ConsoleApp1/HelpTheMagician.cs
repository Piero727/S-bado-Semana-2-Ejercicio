using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HelpTheMagician : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " decide ayudar al mago y usa un hechizo para rastrear al gólem dorado.");
            Console.WriteLine("Gracias a su hechizo logra encontrar al gólem dorado cubierto de lodo.");
            Console.WriteLine("El hechicero le agradece a " + player.Name + ".");
            Console.WriteLine(player.Name + " se despide del mago, de su gólem dorado y sigue su camino.");
            End_1 end = new End_1();
            end.BifurcatedHistory(player);
        }
    }
}
