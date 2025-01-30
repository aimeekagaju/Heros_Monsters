using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Heros_Monsters.Models
{
    public class Orc : ICharacter
    {
        public string Name { get; } = "Orc";
        public int Id { get; set; }
        public int NbrOfLives { get; set; } = 150;

        public IArmor ArmorOrc { get; set; }
        public IWeapon WeaponOrc { get; set; }
        public void PutArmor(IArmor armor)
        {
            ArmorOrc = armor;
            Console.WriteLine($"Orc possess the following armor : {ArmorOrc.Name}");
        }

        public void UseWeapon(IWeapon weapon)
        {
            WeaponOrc = weapon;
            Console.WriteLine($"Orc possess the following weapon : {WeaponOrc.Name} and the following number of lives : {NbrOfLives}");
        }
        public void DisplayCharacterDetails()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Weapon: {WeaponOrc.Name}");
            Console.WriteLine($"Armor: {ArmorOrc.Name}");
        }
    }
}
