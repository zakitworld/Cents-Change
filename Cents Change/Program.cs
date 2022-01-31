using System;

namespace Cents_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;
            const int HALF_DOLLAR = 50;
            const int QUARTER = 25;
            const int DIME = 10;
            const int NICKEL = 5;
            Console.WriteLine("Enter Change in Cents: ");
            change = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The change you entered is: " + change);
            Console.WriteLine("The number of half-dollars to be returned is: " + change / HALF_DOLLAR);
            change = change % HALF_DOLLAR;
            Console.WriteLine("The number of quarters to be returned is: " + change / QUARTER);
            change = change % QUARTER;
            Console.WriteLine("The number of Dime to be returned is: " + change / DIME);
            change = change % DIME;
            Console.WriteLine("The number of nickel to be returned is: " + change / NICKEL);
            change = change % NICKEL;
            Console.WriteLine("The number of pennies to be returned is " + change);
        }
    }
}
