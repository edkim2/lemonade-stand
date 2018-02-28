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
        public double priceOfLemonade;

        // constructor (SPAWNER)
        public Recipe()
        {

        }

        // member methods (CAN DO)
        public int ChoosingLemon()
        {
            Console.WriteLine("How many lemons would you like to use for your recipe?");
            lemon = int.Parse(Console.ReadLine());
            return lemon;
        }

        public int ChoosingCup()
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

        public bool CheckInventoryForLemon(Player player, int lemon)
        {
            if(player.inventory.items[0].Count < lemon)
            {
                Console.WriteLine("You don't have enough lemons.");
                ChoosingLemon();
            }
            return true;
        }

        public bool CheckInventoryForCup(Player player, int cup)
        {
            if (player.inventory.items[1].Count < cup)
            {
                Console.WriteLine("You don't have enough cups.");
                ChoosingCup();
            }
            return true;
        }

        public bool CheckInventoryForIce(Player player, int ice)
        {
            if (player.inventory.items[2].Count < cup)
            {
                Console.WriteLine("You don't have enough ice.");
                ChoosingIce();
            }
            return true;
        }

        public bool CheckInventoryForSugar(Player player, int sugar)
        {
            if (player.inventory.items[3].Count < sugar)
            {
                Console.WriteLine("You don't have enough sugar.");
                ChoosingSugar();
            }
            return true;
        }

        public int AmountOfLemonUsed(int lemon, int cup)
        {
            int totalLemon = lemon * cup;
            return totalLemon;
        }

        public int AmountOfSugarUsed(int sugar, int cup)
        {
            int totalSugar = sugar * cup;
            return totalSugar;
        }

        public int AmountOfIceUsed(int ice, int cup)
        {
            int totalIce = ice * cup;
            return totalIce;
        }

        public void RemoveLemonsFromInventory(Player player, int lemon)
        {
            for (int i = 0; i < lemon; i++)
            {
                player.inventory.items[0].RemoveAt(0);
            }
        }

        public void RemoveCupsFromInventory(Player player, int cup)
        {
            for (int i = 0; i < cup; i++)
            {
                player.inventory.items[1].RemoveAt(0);
            }
        }

        public void RemoveIceFromInventory(Player player, int ice)
        {
            for (int i = 0; i < ice; i++)
            {
                player.inventory.items[2].RemoveAt(0);
            }
        }

        public void RemoveSugarFromInventory(Player player, int sugar)
        {
            for (int i = 0; i < sugar; i++)
            {
                player.inventory.items[3].RemoveAt(0);
            }
        }

        public void CreateLemonade(Player player, int cup)
        {
            for (int i = 0; i < cup; i++)
            {
                player.inventory.AddLemonadeIntoInventory(new Lemonade());
            }
        }

        public double ChooseLemonadePrice()
        {
            Console.WriteLine("How much would you like to sell your lemonade for?");
            priceOfLemonade = double.Parse(Console.ReadLine());
            return priceOfLemonade;
        }

    }
}
