using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do want generated?");
            int n = int.Parse(Console.ReadLine());

            int[] Generated = new int[n];

            for (int i = 0; i < n; i++)
            {
                Generated[i] = Random();
            }

            Console.WriteLine("\nNumbers generated: " + n + "\n");
            Console.WriteLine("Percentage of even numbers: " + PercentageOfEven(Generated, n) + "%");          
            Console.WriteLine("Sum of even numbers: " + SumOfEven(Generated, n));
            Console.WriteLine("Average of even numbers: " + AverageOfEven(Generated, n) + "\n");
           
            Console.WriteLine("Percentage of odd numbers: " + PercentageOfOdd(Generated, n) + "%");
            Console.WriteLine("Sum of odd numbers: " + SumOfOdd(Generated, n));            
            Console.WriteLine("Average of odd numbers: " + AverageOfOdd(Generated, n));

            Console.ReadKey();
        }
        static int Random()
        {
            Random r = new Random();

            return r.Next(0, 1000); 
        }
        static double PercentageOfEven(int[] nums, int n)
        {
            double even = 0;

            for (int i = 0; i < n; i++)
            {
                if(nums[i] % 2 == 0 || nums[i] == 2)
                {
                    even++;
                }
            }

            double Percent = (even / n) * 100;

            return Percent;
        }
        static double PercentageOfOdd(int[] nums, int n)
        {
            double odd = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odd++;
                }
            }

            double Percent = (odd / n) * 100;

            return Percent;
        }
        static int SumOfEven(int[] nums, int n)
        {
            int evennum = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 == 0 || nums[i] == 2)
                {
                    evennum += nums[i];
                }
            }

            return evennum;
        }
        static int SumOfOdd(int[] nums, int n)
        {
            int oddnum = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddnum += nums[i];
                }
            }

            return oddnum;
        }
        static double AverageOfEven(int[] nums, int n)
        {
            int evennum = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 == 0 || nums[i] == 2)
                {
                    evennum += nums[i];
                    even++;
                }
            }

            double Average = evennum / even;
            return Average;
        }
        static double AverageOfOdd(int[] nums, int n)
        {
            int oddnum = 0;
            int odd = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddnum += nums[i];
                    odd++;
                }
            }

            double Average = oddnum / odd;
            return Average;
        }
    }
}
