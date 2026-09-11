using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player : HisAttacks
    {
        Random random = new Random();
        public string Name { get; set; }
        public int Life { get; set; }
        public float Money {  get; set; }

        private List<string> magicBagOfKnowledge = new List<string>();

        public Player(string name, int life, float money)
        {
            Name = name;
            Life = life;
            Money = money;
        }

        public void RockAttack(Enemy enemy)
        {
            int damage = 1;
            enemy.Life -= damage;
            Console.WriteLine(enemy.Name + " recibió " + damage + " de daño");
        }

        public void ElectricAttack(Enemy enemy)
        {
            int damage = random.Next(2, 6);
            enemy.Life -= damage;
            Console.WriteLine(enemy.Name + " recibió " + damage + " de daño");
        }

        public void DarkAttack(Enemy enemy)
        {
            int damage = random.Next(5, 10);
            enemy.Life -= damage;
            Console.WriteLine(enemy.Name + " recibió " + damage + " de daño");
        }

        public void AddContent(string content)
        {
            magicBagOfKnowledge.Add(content);
            
        }

        public void ShowContent()
        {
            foreach (string item in magicBagOfKnowledge)
            {
                Console.WriteLine("Has obtenido el libro de " + item + ".");
            }
        }
    }
}
