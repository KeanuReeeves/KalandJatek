using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Character
    {
        string name;
        string cast;
        int hp;
        int lvl;
        int maxhp;
        int exp;
        int dmg;
        int agi;

        public int Hp
        {
            get => hp;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > maxhp)
                {
                    value = maxhp;
                }
                hp = value;
            }
        }
        public int SzuksegesExp()
        {
            return 25 * lvl;
        }
        public int Lvl { get => lvl; set
            {
                if (value>lvl)
                {
                    Dmg += lvl * 3;
                    Agi += lvl * 2;
                    maxhp += lvl * 20;
                }    
            } 
        }
        public int Exp { get => exp; set
            {
                if (value>SzuksegesExp())
                {
                    lvl++;
                    value -= SzuksegesExp();
                }
                exp = value;
            }
        }
        public int Dmg { get => dmg; set => dmg = value; }
        public int Agi { get => agi; set => agi = value; }

        public Character(string name,string cast)
        {
            this.name = name;
            this.cast = cast;
            
            Lvl = 1;
            Exp = 0;
            if (cast == "warrior")
            {
                Hp = 100;
                maxhp = 100;
                Dmg = 10;
                Agi = 3;
            }
            else if (cast == "mage")
            {
                Hp = 70;
                maxhp = 70;
                Dmg = 20;
                Agi = 2;
            }
            else if (cast == "priest")
            {
                Hp = 90;
                maxhp = 90;
                Dmg = 8;
                Agi = 1;
            }
            else
            { 
                
            }
        }
        public string getName()
        {
            return this.name;
        }

        public string getCast()
        {
            return this.cast;
        }


        public override string ToString()
        {
            return string.Format("\nName:{0}\n" +
                                 "Class: {1}\n" +
                                 "HP: {2}/{3}\n" +
                                 "Exp: {4}/{5}\n" +
                                 "Dmg: {6}\n" +
                                 "Agi: {7}\n", this.name, this.cast,this.hp,this.maxhp,this.exp,this.SzuksegesExp(),this.dmg,this.agi);
        }

    }
}
