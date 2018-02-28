using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public int soldItems;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
        }

        // member methods (CAN DO)
        public int SellLemonade(List<Customer> customer)
        {
            soldItems = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (inventory.items[4].Count == 0)
                {
                    Console.WriteLine("You sold out!");
                }
            }
        }
    }
}
