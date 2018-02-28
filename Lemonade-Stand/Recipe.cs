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
        public void CreateRecipe(Player player)
        {
            Console.WriteLine("Now it's time to make your own recipe for your lemonade stand.");
            Console.WriteLine("You can decide how much of what ingredient goes into your lemonade.");
            Console.WriteLine("Press [1] to make your recipe, [2] to check your inventory, [3] to set your lemonade price, or [4] to exit this part of the game.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    player.inventory.DisplayInventory();
                    lemon = ChoosingLemon();
                    CheckInventoryForLemon(player, lemon);
                    cup = ChoosingCup();
                    CheckInventoryForCup(player, cup);
                    ice = ChoosingIce();
                    CheckInventoryForIce(player, ice);
                    sugar = ChoosingSugar();
                    CheckInventoryForSugar(player, sugar);
                    int totalLemon = AmountOfLemonUsed(lemon, cup);
                    CheckInventoryForLemon(player, totalLemon);
                    int totalIce = AmountOfIceUsed(ice, cup);
                    CheckInventoryForIce(player, totalIce);
                    int totalSugar = AmountOfSugarUsed(sugar, cup);
                    CheckInventoryForSugar(player, totalSugar);
                    RemoveLemonsFromInventory(player, totalLemon);
                    RemoveCupsFromInventory(player, cup);
                    RemoveIceFromInventory(player, totalIce);
                    RemoveSugarFromInventory(player, totalSugar);
                    CreateLemonade(player, cup);
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    CreateRecipe(player);
                    break;

                case "2":
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    CreateRecipe(player);
                    break;

                case "3":
                    if (player.inventory.items[4].Count > 0)
                    {
                        ChooseLemonadePrice();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You need to make some lemonade!");
                        Console.ReadKey();
                        Console.Clear();
                        CreateRecipe(player);
                    }
                    break;
            }
        }

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
