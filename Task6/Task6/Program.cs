using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter W1 = new Warrior("Omar", 70);
            GameCharacter w2 = new Wizard("ali", 70);

            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(W1);
            gameCharacters.Add(w2);

            foreach (var character in gameCharacters)
            {
                Console.WriteLine($"--- {character.Name} Turn ---");
                character.UseSpecialAbility();
                Console.WriteLine($"Health: {character.Health}");

                character.takeDamage(20);
                Console.WriteLine($"Health after damage: {character.Health}");

                character.Heal();
                Console.WriteLine();
            }


        }
    }
}
