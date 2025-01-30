using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Armors
{
    public class HeavyArmor : IArmor
    {
        public string Name { get; } = "Heavy Armor";
        public int Defense { get; set; }
        public int Id { get; set; }

        public void PutArmor()
        {
            Console.WriteLine("Wearing Heavy armor!");
        }
    }
}
