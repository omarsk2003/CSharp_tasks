using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
     abstract class GameCharacter
    {
        private string _name;
        public int _health;
        public string Name { get; set; }

        public int Health { get { return _health; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Health can not be less than 0");
                }
                else if (value > 100)
                {
                    Console.WriteLine("Health can not be greater than 100 ");
                }
                else
                    _health = value;
            }
                
                }

        public void Heal() {
            if (Health >= 100)
            {
                Console.WriteLine("Can not take heal");
            }
            else
            {
                Health += 10;
                Console.WriteLine($"New Health: {Health}");
            } 
        }
        public void Heal(int amount)
        {
            if (Health >= 100)
            { }
            else
            {
                Health += amount;
                Console.WriteLine($"New Health: {Health}");
            }
        }
        public GameCharacter(string n,int h) 
        {
            Health = h;
            Name = n;
        }

        public abstract void UseSpecialAbility();
        public virtual void takeDamage(int a) { Health -= a; }



    }
}
