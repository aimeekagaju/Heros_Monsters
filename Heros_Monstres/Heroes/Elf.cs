using Heros_Monsters.Armors;
using Heros_Monsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Heros_Monsters.Models
{
    public class Elf : ICharacter
    {
        public string Name { get; } = "Elf";
        public int Id { get; set; }
        public int NbrOfLives { get; set; } = 100;
        public IArmor ArmorElf {  get; set; }
        public IWeapon WeaponElf { get; set; }

        public void PutArmor(IArmor armor)
        {
            if(this is Elf)
            {
                armor = new LightArmor();
                ArmorElf = armor;
            }
            if (armor is LightArmor)
            {
                ArmorElf = armor;
            }
            else
            {
                ArmorElf = armor;
                Console.WriteLine($"Elf uses only a light armor!");
            };
        }


        public void UseWeapon(IWeapon weapon)
        {
            WeaponElf = weapon;
            Console.WriteLine($"Elf possess the following weapon : {WeaponElf.Name} and the following number of lives :  {NbrOfLives}");
        }
        public void DisplayCharacterDetails()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Weapon: {WeaponElf.Name}");
            Console.WriteLine($"Armor: {ArmorElf.Name}");
        }
    }
}
