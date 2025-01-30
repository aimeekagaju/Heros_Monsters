using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Armors
{
    public class Armor
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
