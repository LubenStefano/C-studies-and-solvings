using System;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"enter the size of the array");
            
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n]; //{0, 0, 0, ..., n}

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value for {i} element: " );
                arr[i] = int.Parse(Console.ReadLine());
            }
            //{1, 2, 3, 4}
            Console.WriteLine();
            
            Console.Write($"The array is: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}