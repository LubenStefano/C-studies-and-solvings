using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value for {i} element: " );
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Reverse(arr);
            Console.Write($"The reversed array is: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Reverse(int[] arr) //bubble sort
        {
            for(int i = 0; i < arr.Length - 1; i ++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}