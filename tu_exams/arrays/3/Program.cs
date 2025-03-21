using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value for {i} element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write($"The array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int mostCommon = MostCommon(arr);
            Console.WriteLine($"The most common number from the arr is: {mostCommon}");

        }

        static int MostCommon(int[] arr)
        {
            int mostCommon = 0;
            int maxCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int common = 0;
                int counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        common = arr[i];
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostCommon = common;
                }
            }

            return mostCommon;
        }
    }
}