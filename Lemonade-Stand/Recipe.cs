using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        // member variables (HAS A)
        public int lemon;
        public int cup;
        public int ice;
        public int sugar;
        public int priceOfLemonade;

        // constructor (SPAWNER)
        public Recipe()
        {

        }

        // member methods (CAN DO)
        public int ChoosingLemons()
        {
            Console.WriteLine("How many lemons would you like to use for your recipe?");
            lemon = int.Parse(Console.ReadLine());
            return lemon;
        }

        public int ChoosingCups()
        {
            Console.WriteLine("How many cups of lemonade would you like to make?");
            cup = int.Parse(Console.ReadLine());
            return cup;
        }

        public int ChoosingIce()
        {
            Console.WriteLine("How much ice do you want per lemonade?");
            ice = int.Parse(Console.ReadLine());
            return ice;
        }

        public int ChoosingSugar()
        {
            Console.WriteLine("How much sugar do you want per lemonade?");
            sugar = int.Parse(Console.ReadLine());
            return sugar;
        }


    }
}
