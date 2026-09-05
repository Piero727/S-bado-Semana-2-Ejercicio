using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public int Damage { get; set; }

        public Player(string name, int life, int damage)
        {
            Name = name;
            Life = life;
            Damage = damage;
        }
    }
}
