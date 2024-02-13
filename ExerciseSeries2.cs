using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a whole number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            if (number % 2 == 0)
                Console.WriteLine("The number is positive and even");
            else
                Console.WriteLine("The number is positive and odd");
        }
        else if (number < 0)
        {
            if (number % 2 == 0)
                Console.WriteLine("The number is negative and even");
            else
                Console.WriteLine("The number is negative and odd");
        }
        else
        {
            if (number % 2 == 0)
                Console.WriteLine("The number is zero (and it is even)");
            else
                Console.WriteLine("The number is zero (and it is odd)");
        }
    }
}