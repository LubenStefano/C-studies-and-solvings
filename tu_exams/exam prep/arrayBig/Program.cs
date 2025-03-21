using System;

namespace BigArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 1 || n >= 1000)
            {
                Console.WriteLine($"The size is invalid!");

                return;
            }

            int[] arr = InitPrimes(n);
            DebugArr(arr);

            RotateRight(arr);
            DebugArr(arr);

            ReverseInplace(arr);
            DebugArr(arr);

        }

        static int[] InitPrimes(int n)
        {
            int[] arr = new int[n];
            int i = 0;
            int num = 2; // Start checking for prime from 2

            while (i < n)
            {
                if (IsPrime(num))
                {
                    arr[i] = num;
                    i++;
                }
                num++;
            }

            return arr;
        }
        
        static void RotateRight(int[] arr)
        {
            int first = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = first;
        }

        static void ReverseInplace(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j ++)
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }



        static bool IsPrime(int n)
        {
            //since 0 and 1 is not prime return false.
            if (n < 2) return false;

            //Run a loop from 2 to n-1
            for (int i = 2; i < n; i++)
            {
                // if the number is divisible by i, then n is not a prime number.
                if (n % i == 0) return false;
            }
            //otherwise, n is prime number.
            return true;
        }


        static void DebugArr(int[] arr)
        {
            Console.Write($"The arr looks like this: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}