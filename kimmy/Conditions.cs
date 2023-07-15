using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimmy
{
    public class Conditions
    {
        public void conditionOne()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionOne = new List<string>()
            {"Plain Waffle = Php30.00", " ", "How many?"};

            foreach (string i in conditionOne)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 30;

            var dineInOrtakeOut = new List<string>()
            {"Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out",
            " "};

            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        public void conditionTwo()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionTwo = new List<string>()
            {"Peanut Waffle = Php40.00", "How many?", " "};

            foreach (string i in conditionTwo)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 40;

            var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out",
            " "};

            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        public  void conditionThree()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionThree = new List<string>()
            {"Vanilla Waffle = Php45.00", "How many?", " "};

            foreach (string i in conditionThree)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 45;

            var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out",
            " "};

            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        public  void conditionFour()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionFour = new List<string>()
            {"Chocolate Waffle = Php45.00", "How many?", " "};

            foreach (string i in conditionFour)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 45;

            var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out",
            " "};

            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
       public void conditionFive()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionFive = new List<string>()
            {"Strawberry Waffle = Php55.00", "How many?", " "};

            foreach (string i in conditionFive)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 55;

            var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out",
            " "};

            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");

        }

    }
}
