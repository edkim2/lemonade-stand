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
        public List<List<Supply>> supplies;
        List<Supply> lemon;
        List<Supply> cup;
        List<Supply> ice;
        List<Supply> sugar;
        List<Supply> lemonade;
        // constructor (SPAWNER)
        public Inventory()
        {
            supplies = new List<List<Supply>>();
            lemon = new List<Supply>();
            cup = new List<Supply>();
            ice = new List<Supply>();
            sugar = new List<Supply>();
            lemonade = new List<Supply>();
            supplies.Add(lemon);
            supplies.Add(cup);
            supplies.Add(ice);
            supplies.Add(sugar);
            supplies.Add(lemonade);
        }

        // member methods (CAN DO)
    }
}
