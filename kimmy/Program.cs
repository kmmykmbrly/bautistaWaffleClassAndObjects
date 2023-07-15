namespace kimmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            string orderAgain;
            bool Menu = true;
            while (Menu)
            {
                WaffleList waffleList = new WaffleList();
                waffleList.waffleMenu();
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Conditions condition1 = new Conditions();
                    condition1.conditionOne();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }
                else if (userInput == "2")
                {
                    Conditions condition2 = new Conditions();
                    condition2.conditionTwo();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }
                else if (userInput == "3")
                {
                    Conditions condition3 = new Conditions();
                    condition3.conditionThree();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }
                else if (userInput == "4")
                {
                    Conditions condition4 = new Conditions();
                    condition4.conditionFour();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }
                else if(userInput == "5")
                {
                    Conditions condition5 = new Conditions();
                    condition5.conditionFive();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }
            }
        }
    }
}