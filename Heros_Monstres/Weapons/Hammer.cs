using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Weapons
{
    public class Hammer : IWeapon
    {
        public int Id { get; set; }
        public string Name { get; } = "Hammer";

        public void UseWeapon()
        {
            Console.WriteLine("Smashing with the hammer!");
        }
    }
}
