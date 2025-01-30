using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Heros_Monsters.Models
{
    public class Human : ICharacter
    {
        public string Name { get; } = "Human";

        public int Id { get; set; }
        public int NbrOfLives { get; set; } = 120;
        public IArmor ArmorHuman { get; set; }
        public IWeapon WeaponHuman { get; set; }

        public void PutArmor(IArmor armor)
        {
            ArmorHuman = armor;
            Console.WriteLine($"Human possess the following armor : {ArmorHuman.Name}");
        }

        public void UseWeapon(IWeapon weapon)
        {
            WeaponHuman = weapon;
            Console.WriteLine($"Human possess the following weapon : {WeaponHuman.Name} and the following number of lives : {NbrOfLives}");
        }
        public void DisplayCharacterDetails()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Weapon: {WeaponHuman.Name}");
            Console.WriteLine($"Armor: {ArmorHuman.Name}");
        }
    }
}
