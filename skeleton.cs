using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Calculator ===");

        while (true)
        {
            Console.WriteLine("\n Give first number (or q to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            double a = double.Parse(input);

            Console.Write("Give operation (+ - * /):");
            string op = Console.ReadLine();

            Console.Write("Give second number:");
            double b = double.Parse(Console.ReadLine());

            double result = 0;

            if (operation == "+") result = a + b;
            else if (operation == "-") result = a - b;
            else if (operation == "*") result = a * b;
            else if (operation == "/") result = a / b;
            else
            {
                Console.WriteLine("Unknown operation!");
                continue;
            }
            Console.WriteLine($"Result: {result}");
        }
        Console.WriteLine("Goodbye!");
    }
}