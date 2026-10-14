using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
     class Wizard:GameCharacter
    {

        public Wizard(string n, int h) : base(n, h) { }
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");

        }
        public override void takeDamage(int a)
        {
            base.takeDamage(a);

        }

    }
}
