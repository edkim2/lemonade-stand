using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {
        // member variables (HAS A)

        // constructor (SPAWNER)
        public UserInterface()
        {

        }

        // member methods (CAN DO)

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand.");
            Console.WriteLine("You will have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand!");
            Console.WriteLine("You will have complete control over your business.");
            Console.WriteLine("Including pricing, quality control, inventory control, and purchasing supplies.");
            Console.WriteLine("Please hit [ENTER] to continue.");
        }
    }
}
