using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Monsters.Interfaces
{
    public interface ICharacter
    {
        void UseWeapon(IWeapon weapon);
        void PutArmor(IArmor armor);
        void DisplayCharacterDetails();
    }
}
