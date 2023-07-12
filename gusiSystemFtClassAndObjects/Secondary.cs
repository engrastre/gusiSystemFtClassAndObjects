using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gusiSystemClassandObjects
{
    public class Secondary
    {
        int number = 1;
        public List<string> sideFries;
        public List<string> sideBeverage;
        public Secondary()
        {
            sideFries = new List<string>() { "CHEESE FRIES", "SWEET POTATO FRIES" };
            sideBeverage = new List<string>() { "SODA", "JUICE" };
        }
        public void frieslist()
        {
            Console.WriteLine("\nWhat kind of fries do you like?");
            foreach (string fries in sideFries)
            {
                Console.WriteLine(number + ". " + fries);
                number++;
            }
            Console.Write("Select your fries: ");
        }
        public void beveragelist()
        {
            Console.WriteLine("\nWhat kind of beverage do you like?");
            foreach (string beverage in sideBeverage)
            {
                Console.WriteLine(number + ". " + beverage);
                number++;
            }
            Console.Write("Select your beverage: ");
        }
    }
}
