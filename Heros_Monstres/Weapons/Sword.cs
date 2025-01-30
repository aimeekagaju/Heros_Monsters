using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Weapons
{
    public class Sword : IWeapon
    {
        public int Id { get; set; }
        public string Name { get; } = "Sword";

        public void UseWeapon()
        {
            Console.WriteLine("Swinging the sword!");
        }
    }
}
