using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface HisAttacks
    {
        void RockAttack(Enemy enemy);
        void ElectricAttack(Enemy enemy);
        void DarkAttack(Enemy enemy);
    }
}
