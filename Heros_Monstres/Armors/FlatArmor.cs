using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Armors
{
    public class FlatArmor : IArmor
    {
        public string Name { get; } = "Flat Armor";
        public int Defense { get; set; }
        public int Id { get; set; }

        public void PutArmor()
        {
            Console.WriteLine("Wearing flat armor!");
        }
    }
}
