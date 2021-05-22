using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What function would you like to use today?\n(Please enter a letter from A-F)\n\n");
            Calculator();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void Calculator()
        {

            Console.WriteLine("A. Addition\nB. Subtraction\nC. Multiplication\nD. Division\nE. Power of\nF. Square root\n\n");           
            string input = Console.ReadLine().ToUpper();


            switch (input)
            {
                case "A":
                    Console.WriteLine("\nResult = " + Add() + "\n\n");
                    break;
                case "B":
                    Console.WriteLine("\nResult = " + Subtract() + "\n\n");
                    break;
                case "C":
                    Console.WriteLine("\nResult = " + Multiply() + "\n\n");
                    break;
                case "D":
                    Console.WriteLine("\nResult = " + Divide() + "\n\n");
                    break;
                case "E":
                    Console.WriteLine("\nResult = " + Power() + "\n\n");
                    break;
                case "F":
                    Console.WriteLine("\nResult = " + SquareRoot() + "\n\n");
                    break;

            }
            Calculator();
        }
        static double[] Number()
        {
            Console.WriteLine("Please enter the numbers:");
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());

            double[] Nums = new double[2];
            Nums[0] = a;
            Nums[1] = b;

            return Nums;
        }
        static double Multiply()
        {
            double[] Digits = Number();
            
            return Digits[0] * Digits[1];
        }
        static double Divide()
        {
            double[] Digits = Number();

            if(Digits[1] == 0)
            {
                Console.WriteLine("Error. Cannot to divide by zero.");
                return 0;
            }

            return Digits[0] / Digits[1];
        }
        static double Add()
        {
            double[] Digits = Number();

            return Digits[0] + Digits[1];
        }
        static double Subtract()
        {
            double[] Digits = Number();

            return Digits[0] - Digits[1];
        }
        static double Power()
        {
            Console.Write("Please enter the base number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the root number: ");
            double b = double.Parse(Console.ReadLine());

            return Math.Pow(a,b);
        }
        static double SquareRoot()
        {
            Console.WriteLine("Please enter the number: ");
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());

            return Math.Sqrt(a);
        }
    }
}
