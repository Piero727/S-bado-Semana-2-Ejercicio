using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BottleWithWater : History
    {
        public override void BifurcatedHistory(Player player)
        {
            Console.WriteLine(player.Name + " le da su botella con agua al gran árbol seco.");
            Console.WriteLine("El gran árbol seco empieza a recuperarse por completo.");
            Console.WriteLine("Ahora el gran árbol ya recuperó toda su energía y comenzó a restaurar la vegetación de todo el bosque.");
            Console.WriteLine("El gran árbol le pregunta si puede devolverle el favor.");
            Console.WriteLine(player.Name + " saca su mapa para ver qué tan lejos está su parque favorito y le pide que lo lance con todas sus fuerzas para poder planear hasta allí.");
            Console.WriteLine("El gran árbol le responde que sí puede hacerlo.");
            Console.WriteLine("El gran árbol agarra a " + player.Name + ", le indica la dirección en la que debe lanzarlo y lo impulsa con todas sus fuerzas.");
            Console.WriteLine(player.Name + " sale a toda velocidad; al tocar las nubes saca su planeador y planea hasta llegar a su destino.");
            End_2 end = new End_2();
            end.BifurcatedHistory(player);
        }
    }
}
