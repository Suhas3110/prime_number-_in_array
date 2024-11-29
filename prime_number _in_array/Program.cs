using System;

namespace prime_number_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Prime numbers in the array are:");

            for (int j = 0; j < 10; j++)
            {
                int count = 0;

                // Check for divisors of arr[j]
                for (int k = 1; k <= arr[j]; k++)
                {
                    if (arr[j] % k == 0)
                    {
                        count++;
                    }
                }

                // If the number is prime, it will have exactly 2 divisors
                if (count == 2)
                {
                    Console.WriteLine(arr[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
