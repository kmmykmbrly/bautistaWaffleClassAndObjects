using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kimmy
{
    public class WaffleList
    {
        public List<string> waffleMenu;
        public WaffleList()
        {
            waffleMenu = new List<string>()
            { "Welcome to Waffle-O!", "***************** Menu *****************", "1. Plain Waffle      ---------------Php30.00",
            "2. Peanut Waffle     ---------------Php40.00", "3. Vanilla Waffle    ---------------Php45.00",
            "4. Chocolate Waffle  ---------------Php45.00", "5. Strawberry Waffle ---------------Php55.00",
            "--------------------------------------------", " "};
        }
        public void MenuOfwaffle() {
            foreach (string waffle in waffleMenu)
            {
                Console.WriteLine(waffle);
            }

            var gettingOrder = new List<string>()
            {"Can I get your order po?", "Please select the number you want to order", " "};

            foreach (string i in gettingOrder)
            {
                Console.WriteLine(i);
            }

        }
    }
}
