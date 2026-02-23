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

            Console.WriteLine("Give operation (+ - * /):");
            string op = Console.ReadLine();

            Console.WriteLine("Give second number:");
            double b = double.Parse(Console.ReadLine());

            double result = Calculate(a, b, op);
            Console.WriteLine($"Result: {result}");
        }
    }

    static double Calculate(double a, double b, string op)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return b != 0 ? a / b : 0;
            default:
                Console.WriteLine("Unknown operation!");
                return 0;
        }
    }
}