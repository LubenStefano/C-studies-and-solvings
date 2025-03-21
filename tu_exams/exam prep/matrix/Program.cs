using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size(n): ");
            
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            InitMatrix(matrix);
            Console.WriteLine("The matrix is: ");

            //debuging
            PrintMatrix(matrix);
            Console.WriteLine();
            

            int[] rowSums = GetRowSums(matrix);
            Console.WriteLine("The sums are: ");

            //debuging
            foreach(int sum in rowSums)
            {
                Console.Write($"{sum} ");   
            }
            Console.WriteLine();
            
            int counter = GetPrimesCount(rowSums);

            //debuging
            Console.WriteLine($"The count of the prime numbers from the sums is: {counter}");
            
        }

        static void InitMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i < j)
                    {
                        int n = 5;
                        matrix[i, j] = 4 * j - Power(i, n); //i^n
                    }
                    else if(i == j)
                    {
                        matrix[i, j] = 0;
                    }
                    else{
                        matrix[i, j] = i + j;
                    }
                }
            }
        }

        static int Power(int number, int power)
        {
            if(power == 1 || power == 0)
            {
                return number;
            }

            return number * Power(number, power - 1);
        }

        static int[] GetRowSums(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(0)];

            for(int i =0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                sums[i] = sum; 
            }

           return sums;
        }

        static int GetPrimesCount(int[] arr) //{1, 2, 3}
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    break;
                }
                for(int j = 2; j * j <= arr[i]; j++)
                {
                    if(arr[i] % j ==0)
                    {
                        break;
                    }
                }
                counter++;
            }

            return counter;
        }

        //for debuging
        static void PrintMatrix(int[,] matrix)
        {
            for(int i =0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}