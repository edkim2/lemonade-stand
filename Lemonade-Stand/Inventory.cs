using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        // member variables (HAS A)
        public double money = 35.00;
        public double profit;
        public List<List<Supply>> items;
        List<Supply> lemon;
        List<Supply> cup;
        List<Supply> ice;
        List<Supply> sugar;
        List<Supply> lemonade;
        // constructor (SPAWNER)
        public Inventory()
        {
            items = new List<List<Supply>>();
            lemon = new List<Supply>();
            cup = new List<Supply>();
            ice = new List<Supply>();
            sugar = new List<Supply>();
            lemonade = new List<Supply>();
            items.Add(lemon);
            items.Add(cup);
            items.Add(ice);
            items.Add(sugar);
            items.Add(lemonade);
        }

        // member methods (CAN DO)
        public void AddLemonIntoInventory(Lemon lemon)
        {
            items[0].Add(lemon);
        }

        public void AddCupIntoInventory(Cup cup)
        {
            items[1].Add(cup);
        }

        public void AddIceIntoInventory(Ice ice)
        {
            items[2].Add(ice);
        }

        public void AddSugarIntoInventory(Sugar sugar)
        {
            items[3].Add(sugar);
        }

        public void AddLemonadeIntoInventory(Lemonade lemonade)
        {
            items[4].Add(lemonade);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Here is your current inventory:");
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Lemons: " + items[0].Count);
            Console.WriteLine("Cups: " + items[1].Count);
            Console.WriteLine("Ice: " + items[2].Count);
            Console.WriteLine("Sugar: " + items[3].Count);
            Console.WriteLine("Lemonade: " + items[4].Count);
        }
    }
}
