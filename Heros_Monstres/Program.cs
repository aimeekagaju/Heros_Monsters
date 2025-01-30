using Heros_Monsters.Factory;
using Heros_Monsters.Interfaces;
using Heros_Monsters.Models;

Console.WriteLine("Welcome to the Character Creation System!");


Console.WriteLine("Choose your character (Elf, Human, Orc): ");
string characterChoice = Console.ReadLine()?.ToLower();

ICharacter character = characterChoice switch
{
    "elf" => new Elf(),
    "human" => new Human(),
    "orc" => new Orc(),
    _ => throw new ArgumentException("Unknown character type!")
};


Console.WriteLine("Choose your weapon (Sword, Bow): ");
string weaponChoice = Console.ReadLine();
IWeapon weapon = EquipmentFactory.CreateWeapon(weaponChoice);


Console.WriteLine("Choose your armor (FlatArmor, LightArmor): ");
string armorChoice = Console.ReadLine();
IArmor armor = EquipmentFactory.CreateArmor(armorChoice);


character.UseWeapon(weapon);
character.PutArmor(armor);


character.DisplayCharacterDetails();