using System;
class Program
{
    static void Main(string[] args)
    {
        double number1, number2;
        string operation;
        Console.WriteLine("Simple Calcutaor C#");

        Console.Write("Enter first number:  ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Choose the operation : +, -, *, /, % :  ");
        operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());


        switch (operation)
        {
            case "+":
                Console.WriteLine($"The result is: {number1} + {number2}= {number1 + number2}");
            break;
            case "-":
                Console.WriteLine($"The result is: {number1} - {number2}= {number1 - number2}");
            break;
            case "*":
                Console.WriteLine($"The result is: {number1} * {number2}= {number1 * number2}");
            break;
            case "/":
                if (number2 != 0)
                {
                    Console.WriteLine($"The result is: {number1} / {number2}= {number1 / number2}");
                }
                else
                {
                    Console.WriteLine($"Isn't possible");
                }
                break;
            case "%":
                Console.WriteLine($"The result is: {number1} % {number2}= {number1 % number2}");
            break;
        }
    }
}