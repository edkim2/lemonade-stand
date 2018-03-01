using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        // member variables (HAS A)
        public double fullCost;
        Recipe recipe;
        // constructor (SPAWNER)
        public Store()
        {
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public void PurchasingItemsFromStore(Player player)
        {
            Console.WriteLine("You are now at the Store. You can purchase the ingredients to make your lemonade.");
            Console.WriteLine("Press [1] to purchase items, [2] to check your inventory, [3] to exit the store.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    player.inventory.DisplayInventory();
                    int lemon = BuyLemonFromStore(player);
                    MovePurchasedLemonToInventory(player, lemon);
                    int ice = BuyIceFromStore(player);
                    MovePurchasedIceToInventory(player, ice);
                    int cup = BuyCupFromStore(player);
                    MovePurchasedCupToInventory(player, cup);
                    int sugar = BuySugarFromStore(player);
                    MovePurchasedSugarToInventory(player, sugar);
                    GetFullCostOfItems(lemon * new Lemon().price, ice * new Ice().price, cup * new Cup().price, sugar * new Sugar().price);
                    Console.Clear();
                    PurchasingItemsFromStore(player);
                    break;

                case "2":
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    PurchasingItemsFromStore(player);
                    break;

                case "3":
                    recipe.CreateRecipe(player);
                    break;


            }
        }

        public double GetFullCostOfItems(double costOfLemon, double costOfIce, double costOfCup, double costOfSugar)
        {
            double fullCost;
            fullCost = costOfLemon + costOfIce + costOfCup + costOfSugar;
            return fullCost;
        }

        public int BuyLemonFromStore(Player player)
        {
            Console.WriteLine("Each lemon costs $0.10. How many lemons would you like to purchase?");
            int lemon = int.Parse(Console.ReadLine());
            if (!UseMoneyForLemon(player, GetCostOfLemon(lemon)))
            {
                return BuyLemonFromStore(player);
            }
            return lemon;
        }

        public double GetCostOfLemon(int lemon)
        {
            double cost;
            cost = lemon * new Lemon().price;
            return cost;
        }

        public bool UseMoneyForLemon(Player player, double cost)
        {
            if(player.inventory.money >= cost)
            {
                player.inventory.money -= cost;
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase that amount of lemons.");
                return false;
            }
        }

        public void MovePurchasedLemonToInventory(Player player, int lemon)
        {
            for (int i = 0; i < lemon; i++)
            {
                player.inventory.AddLemonIntoInventory(new Lemon());
            }
        }

        public int BuyIceFromStore(Player player)
        {
            Console.WriteLine("Each ice costs $0.10. How much ice would you like to purchase?");
            int ice = int.Parse(Console.ReadLine());
            if (!UseMoneyForIce(player, GetCostOfIce(ice)))
            {
                return BuyIceFromStore(player);
            }
            return ice;
        }

        public double GetCostOfIce(int ice)
        {
            double cost;
            cost = ice * new Ice().price;
            return cost;
        }

        public bool UseMoneyForIce(Player player, double cost)
        {
            if (player.inventory.money >= cost)
            {
                player.inventory.money -= cost;
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase that amount of ice.");
                return false;
            }
        }

        public void MovePurchasedIceToInventory(Player player, int ice)
        {
            for (int i = 0; i < ice; i++)
            {
                player.inventory.AddIceIntoInventory(new Ice());
            }
        }

        public int BuySugarFromStore(Player player)
        {
            Console.WriteLine("Each sugar costs $0.10. How much sugar would you like to purchase?");
            int sugar = int.Parse(Console.ReadLine());
            if (!UseMoneyForSugar(player, GetCostOfSugar(sugar)))
            {
                return BuySugarFromStore(player);
            }
            return sugar;
        }

        public double GetCostOfSugar(int sugar)
        {
            double cost;
            cost = sugar * new Sugar().price;
            return cost;
        }

        public bool UseMoneyForSugar(Player player, double cost)
        {
            if (player.inventory.money >= cost)
            {
                player.inventory.money -= cost;
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase that amount of sugar.");
                return false;
            }
        }

        public void MovePurchasedSugarToInventory(Player player, int sugar)
        {
            for (int i = 0; i < sugar; i++)
            {
                player.inventory.AddSugarIntoInventory(new Sugar());
            }
        }

        public int BuyCupFromStore(Player player)
        {
            Console.WriteLine("Each cup costs $0.10. How many cups would you like to purchase?");
            int cup = int.Parse(Console.ReadLine());
            if (!UseMoneyForCup(player, GetCostOfCup(cup)))
            {
                return BuyCupFromStore(player);
            }
            return cup;
        }

        public double GetCostOfCup(int cup)
        {
            double cost;
            cost = cup * new Cup().price;
            return cost;
        }

        public bool UseMoneyForCup(Player player, double cost)
        {
            if (player.inventory.money >= cost)
            {
                player.inventory.money -= cost;
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase that amount of cups.");
                return false;
            }
        }

        public void MovePurchasedCupToInventory(Player player, int cup)
        {
            for (int i = 0; i < cup; i++)
            {
                player.inventory.AddCupIntoInventory(new Cup());
            }
        }
    }
}
