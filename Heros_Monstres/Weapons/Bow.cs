using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Weapons
{
    public class Bow : IWeapon
    {
        public int Id { get; set; }
        public string Name { get; } = "Bow";

        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow!");
        }
    }
}
