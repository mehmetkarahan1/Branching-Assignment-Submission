
using System;

public class ExpressShippingQuote
{
    public static void Main()
    {
        Console.WriteLine("*** Welcome to Package Express ***");
        Console.WriteLine("Let's get started with your package details.
");

        Console.Write("Enter the package's weight in pounds: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Oops! That doesn't look like a valid number for weight.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("This package is too heavy to be accepted by Package Express.");
            return;
        }

        Console.Write("Now enter the package width in inches: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Invalid input for width.");
            return;
        }

        Console.Write("Enter the height of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Invalid input for height.");
            return;
        }

        Console.Write("Finally, enter the length of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Invalid input for length.");
            return;
        }

        decimal sumDimensions = width + height + length;

        if (sumDimensions > 50)
        {
            Console.WriteLine("Sorry! Your package exceeds the size limits for our service.");
            return;
        }

        decimal quote = (width * height * length * weight) / 100m;
        Console.WriteLine($"
>>> Your estimated shipping cost is: ${quote:F2}");
        Console.WriteLine("Thanks for choosing Package Express. Safe shipping!");
    }
}
