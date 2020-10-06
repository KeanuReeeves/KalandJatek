using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Interactions
    {
        public void Fight(Character character1, Character character2)
        {
            if(character1.Hp <= 0 || character2.Hp <= 0)
            {
                Console.WriteLine("Az egyik harcos halott");
            }

            if(character1.Agi > character2.Agi)
            {
                character2.Hp -= character1.Dmg;
                character1.Exp += 5;

                if(character2.Hp <= 0)
                {
                    character1.Exp += 10;
                }
            }
            else
            {
                character1.Hp -= character2.Dmg;
                character2.Exp += 5;

                if (character1.Hp <= 0)
                {
                    character2.Exp += 10;
                }
            }
        }

        public void Heal(Character character)
        {
            int heal_value = 0;
            if (character.getCast() == "warrior")
            {
                heal_value = 2;
            }
            if (character.getCast() == "mage")
            {
                heal_value = 4;
            }
            if (character.getCast() == "priest")
            {
                heal_value = 6;
            }
            character.Hp += heal_value;
            Console.WriteLine(character.getName() + " healed (+" + heal_value + ")");
        }
    }
}
