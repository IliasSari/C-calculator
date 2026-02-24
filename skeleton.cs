using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator");

        while (true)
        {
            Console.Write("Give a number (or 'q' to quit): ");
            string input = Console.ReadLine();

            if (input == "q")
                break;

            double a = double.Parse(input);

            Console.Write("Give operation (+ - * /): ");
            string operation = Console.ReadLine();

            Console.Write("Give second number: ");
            double b = double.Parse(Console.ReadLine());

            bool validOperation = true;
            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    validOperation = false;
                }
                else
                {
                    result = a / b;
                }
            }
            else
            {
                Console.WriteLine("Wrong operation! Please use only + - * /");
                validOperation = false;
            }

            if (validOperation)
            {
                Console.WriteLine($"✅ Result: {result}");
            }
        }

        Console.WriteLine("Exiting the program.");
    }
}