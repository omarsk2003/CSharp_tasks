using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
     class HealthPotion: ICollectible
    {
        public string PotionName { set; get; }
        public void Collect() 
        { 
        
        }
        public void Use(GameCharacter character,string amounttext) {
            try
            {
                int newamounttext = Convert.ToInt32(amounttext);
            }
            catch { Console.WriteLine("Invaild input"); }
        }
    }
}
