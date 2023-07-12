using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gusiSystemClassandObjects
{
    public class Menu
    {
        int number = 1;
        public List<string> mainList;
        public List<string> secondaryList;
        public void menu()
        {
            Console.WriteLine("**************************-WELCOME TO GUCCIGANGS MIX AND MATCH-**************************");

            Console.WriteLine();
            Console.WriteLine("                             GUCCIGANG'S MIX AND MATCH!");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 1: CHOOSE YOUR MAIN");
            Console.WriteLine();
            Console.WriteLine("                      BURGER              SPAGHETTI                 CHICKEN");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 2: CHOOSE YOUR SIDE");
            Console.WriteLine();
            Console.WriteLine("                      FRIES                           BEVERAGE  ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.Write("Press 1 to continue: ");
        }

        public void offeredMains()
        {
            Menu menu = new Menu();
            menu.mainList = new List<string>() { "BURGER", "SPAGHETTI", "CHICKEN" };
            Console.WriteLine("\nSTEP 1:\nPick your main. ");
            foreach (string list in menu.mainList)
            {
                Console.WriteLine(number + ". " + list);
                number++;
            }
            Console.Write("Select your main: ");
        }
        public void offeredPairs()
        {
            Menu menu2 = new Menu();
            menu2.secondaryList = new List<string>() { "FRIES", "BEVERAGE" };
            Console.WriteLine("\nSTEP 2:\nPick your side. ");
            foreach (string list2 in menu2.secondaryList)
            {
                Console.WriteLine(number + ". " + list2);
                number++;
            }
            Console.Write("Select your side: ");
        }
        public void invalidInput()
        {
            Console.WriteLine("\nINVALID INPUT!!! THE SYSTEM NEEDS TO RESTART!!!!!!!!");
            Console.WriteLine("Please select the appropriately input.");
            Console.WriteLine("Select any number to restart your order.");
            Console.Write(">>");
        }
        public void menuu()
        {
            Console.WriteLine("\n**************************-WELCOME TO GUCCIGANGS MIX AND MATCH-**************************");

            Console.WriteLine();
            Console.WriteLine("                             GUCCIGANG'S MIX AND MATCH!");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 1: CHOOSE YOUR MAIN");
            Console.WriteLine();
            Console.WriteLine("                      BURGER              SPAGHETTI                 CHICKEN");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 2: CHOOSE YOUR SIDE");
            Console.WriteLine();
            Console.WriteLine("                      FRIES                           BEVERAGE  ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
    }
}
