using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gusiSystemClassandObjects
{
    public class Primary
    {
        int number = 1;
        public List<string> mainBurger;
        public List<string> mainSpaghetti;
        public List<string> mainChicken;
        public Primary()
        {
            mainBurger = new List<string>() { "CLASSIC CHEESEBURGER", "VEGGIE BURGER" };
            mainSpaghetti = new List<string>() { "CLASSIC SPAGHETTI", "SPAGHETTI ALLA CARBONARA" };
            mainChicken = new List<string>() { "FRIED CHICKEN SANDWITCH", "CHICKEN W/ WAFFLES" };
        }
        public void burgerList()
        {
            Console.WriteLine("\nWhat kind of burger do you like?");
            foreach (string burger in mainBurger)
            {
                Console.WriteLine(number + ". " + burger);
                number++;
            }
            Console.Write("Select your burger: ");
        }
        public void spaghettiList()
        {
            Console.WriteLine("\nWhat kind of spaghetti do you like?");
            foreach (string spaghetti in mainSpaghetti)
            {
                Console.WriteLine(number + ". " + spaghetti);
                number++;
            }
            Console.Write("Select your spaghetti: ");
        }
        public void chickenList()
        {
            Console.WriteLine("\nWhat kind of chicken do you like?");
            foreach (string chicken in mainChicken)
            {
                Console.WriteLine(number + ". " + chicken);
                number++;
            }
            Console.Write("Select your chicken: ");
        }
    }

}
