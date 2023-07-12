using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gusiSystemFtClassAndObjects
{
    public class Payment
    {
       public void pay()
        {
            int price = 150;
            Console.Write("Enter the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int bill = price * quantity;
            Console.WriteLine("Your bill is " + bill + ".00 pesos");
            Console.Write("Enter the amount of your payment: ");
            int payment = Convert.ToInt32(Console.ReadLine());
            int change = payment - bill;
            Console.Write("Your change is " + change);
            Console.WriteLine();

        }
    }
}
