using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Maffioze
    {
        public string name;
        public int xp;
        public int dmg;
        public int mp;
        public int armor;
        public bool alive;
        public Maffioze(string name, int xp, int dmg, int mp, int armor, bool alive)
        {
            this.name = name;
            this.xp = xp;
            this.dmg = dmg;
            this.mp = mp;
            this.armor = armor;
            this.alive = alive;
        }
        public void attack(Maffioze m)
        {
            if (this.alive == true)
            {
                m.xp -= this.dmg;
            }
            if (this.alive != true)
            {
                Console.WriteLine("ИДИОООООООООООООООООООООООООООООООООООООООООООТ!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
        public void attack(Slut m)
        {
            if (this.alive == true)
            {
                m.xp -= this.dmg;
            }
            if (this.alive != true)
            {
                Console.WriteLine("ИДИОООООООООООООООООООООООООООООООООООООООООООТ!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
        public void attack(Chupocabra m)
        {
            if (this.alive == true)
            {
                m.xp -= this.dmg;
            }
            if (this.alive != true)
            {
                Console.WriteLine("ИДИОООООООООООООООООООООООООООООООООООООООООООТ!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
        public void attack(Demonessa m)
        {
            if (this.alive == true)
            {
                m.xp -= this.dmg;
            }
            if (this.alive != true)
            {
                Console.WriteLine("ИДИОООООООООООООООООООООООООООООООООООООООООООТ!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}

