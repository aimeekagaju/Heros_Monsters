using Heros_Monsters.Armors;
using Heros_Monsters.Interfaces;
using Heros_Monsters.Models;
using Heros_Monsters.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Factory
{
    public abstract class EquipmentFactory
    {
        public static IWeapon CreateWeapon(string weaponType)
        {
            switch (weaponType.ToLower())
            {
                case "sword":
                    return new Sword();
                case "bow":
                    return new Bow();
                case "hammer":
                    return new Hammer();
                default:
                    throw new ArgumentException("Unknown weapon type!");
            }
        }

        // Méthode pour créer une armure
        public static IArmor CreateArmor(string armorType)
        {
            switch (armorType.ToLower())
            {
                case "flatarmor":
                    return new FlatArmor();
                case "lightarmor":
                    return new LightArmor();
                case "heavyarmor":
                    return new HeavyArmor();
                default:
                    throw new ArgumentException("Unknown armor type!");
            }
        }
    }
}
