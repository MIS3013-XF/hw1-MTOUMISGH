// HW1a Sales Total

// Your Name: Matthew Tran
// Did you seek help ? If yes, specify the helper or web link here: Visited office hours for GitHub help.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item;

            double count;
            string countString;

            double price;
            string priceString;


            const double taxrate = 0.085;


            Console.WriteLine("What is the name of the product that you are buying?");
            item = Console.ReadLine();

            Console.WriteLine($"List how many {item}(s/ies) that you want to buy.");
            countString = Console.ReadLine();
            count = Convert.ToDouble(countString);

            Console.WriteLine($"List the price for each {item}");
            priceString = Console.ReadLine();
            price = Convert.ToDouble(priceString);

            double subtotal = price * count; //cost before tax, all var in section needs to be defined after inputs
            double salestax = subtotal * taxrate;
            double saletotal = salestax + subtotal; //total of tax and subtotal
            Console.WriteLine("The subtotal for your purchase is " + subtotal.ToString("C2"));
            Console.WriteLine("The tax for your purchase is " + salestax.ToString("C2"));
            Console.WriteLine("The total cost for the sale is " + saletotal.ToString("C2"));

            Console.ReadKey();
        }
    }
}
