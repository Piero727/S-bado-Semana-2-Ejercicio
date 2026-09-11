using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Life {  get; set; }
        public int Damage { get; set; }
        public Enemy(string name, int life, int damage)
        {
            Name = name;
            Life = life;
            Damage = damage;
        }
        public void CausingDamage(Player player)
        {
            if (Life > 0)
            {
                player.Life -= Damage;
                Console.WriteLine("Ahora es el turno del " + Name);

                Console.WriteLine("Vida del enemigo: " + Life);

                Console.WriteLine(Name + " ataca a " + player.Name);

                Console.WriteLine(player.Name + " recibió " + Damage + " de daño");
            }

            else
            {
                Life = 0;
                Console.WriteLine("Vida del enemigo: " + Life);
            }
                

        }
    }
}
