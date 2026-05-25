// Lets create a class to hold fractions,
// The class should be in its own,
// The class should have two attributes for the top and bottom numbers,
// Make sure the attributes are private.

using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test fraction: 1 (using single-parameter constructor)
            Fraction frac1 = new Fraction(1);
            Console.WriteLine($"Fraction: {frac1.GetFractionString()}");
            Console.WriteLine($"Decimal: {frac1.GetDecimalValue()}");

            // Test fraction: 5 (using single-parameter constructor)
            Fraction frac2 = new Fraction(5);
            Console.WriteLine($"Fraction: {frac2.GetFractionString()}");
            Console.WriteLine($"Decimal: {frac2.GetDecimalValue()}");

            // Test fraction: 3/4 (using two-parameter constructor)
            Fraction frac3 = new Fraction(3, 4);
            Console.WriteLine($"Fraction: {frac3.GetFractionString()}");
            Console.WriteLine($"Decimal: {frac3.GetDecimalValue()}");

            // Test fraction: 1/3 (using two-parameter constructor)
            Fraction frac4 = new Fraction(1, 3);
            Console.WriteLine($"Fraction: {frac4.GetFractionString()}");
            Console.WriteLine($"Decimal: {frac4.GetDecimalValue()}");
        }
    }
}
