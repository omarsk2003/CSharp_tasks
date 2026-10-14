using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
     class Warrior:GameCharacter
    {

        public Warrior(string n,int h):base(n,h) { }
        public override void UseSpecialAbility() 
        {
            Console.WriteLine("The Warrior attacks with a sword!");

        }
        public override void takeDamage(int a)
        {
            base.takeDamage(a / 2);

        }

    }
}
