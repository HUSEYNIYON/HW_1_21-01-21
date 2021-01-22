using System;

namespace HW_1_21_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            if (A != B)
            {
                if (A > B)
                {
                    Console.WriteLine($"A = {A}");
                    Console.WriteLine($"B = {B = A}");
                }
                else
                {
                    Console.WriteLine($"A = {A = B}");
                    Console.WriteLine($"B = {B}");
                }
            }
            else if (A == B)
            {
                Console.WriteLine($"A = {A = 0}");
                Console.WriteLine($"B = {B = 0}");
            }

            //Task 3
            var firstOperand = Convert.ToDouble(Console.ReadLine());
            var secondOperand = Convert.ToDouble(Console.ReadLine());
            char sign = Convert.ToChar(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine($"Result = {firstOperand + secondOperand}");
                    break;
                case '-':
                    Console.WriteLine($"Result = {firstOperand - secondOperand}");
                    break;
                case '*':
                    Console.WriteLine($"Result = {firstOperand * secondOperand}");
                    break;
                case '/':
                    if (secondOperand != 0)
                        Console.WriteLine($"Result = {firstOperand / secondOperand}");
                    else
                        Console.WriteLine("Can't divide by zero!");
                    break;
                default:
                    Console.WriteLine("Incorrect sign!");
                    break;
            }

            //Task4
            var number = Convert.ToDouble(Console.ReadLine());
            if (number >= 0 && number <= 15)
            {
                Console.WriteLine("[0..15]");
            }
            else if (number > 15 && number <= 35)
            {
                Console.WriteLine("[16..35]");
            }
            else if (number > 35 && number <= 50)
            {
                Console.WriteLine("[36..50]");
            }
            else if (number > 50 && number <= 100)
            {
                Console.WriteLine("[51..100]");
            }
            else {
                Console.WriteLine("Wrong number!");
            }
        }
    }
}
