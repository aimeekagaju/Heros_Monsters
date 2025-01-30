using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Armors
{
    public class LightArmor : IArmor
    {
        public string Name { get; set; } = "Light Armor";
        public int Defense { get; set; }
        public int Id { get; set; }

        public LightArmor()
        {
            Name = "Light Armor";
            Defense = 20;
        }

        public void PutArmor()
        {
            Console.WriteLine($"The armor {Name} reduces damages by {Defense} points.");
        }


    }
}
