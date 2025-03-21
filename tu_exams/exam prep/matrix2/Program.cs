using System;
using System.Runtime.Intrinsics.Arm;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReadTriangleMatrix();
            DebugMatrix(matrix);

            int[] columnsMax = GetColumnsMax(matrix);
            DebugArr(columnsMax);

            (int min, int max) = GetMinMax(columnsMax);
            Console.WriteLine($"{min} is min from the columnsMax and {max} is the max");
            
            
        }

        static int[,] ReadTriangleMatrix()
        {
            Console.WriteLine($"Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0 + i; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value for {i + 1}|{j + 1} ");
                    
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        static int[] GetColumnsMax(int[,] matrix)
        {
            int[] columnsMax = new int[matrix.GetLength(1)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(matrix[i, j] > columnsMax[j])
                    {
                        columnsMax[j] = matrix[i, j];
                    }
                }
            }

            return columnsMax;
        }

        static (int, int) GetMinMax(int[] arr)
        {
            int min = 0;
            int max = 0;

            for(int i =0; i < arr.Length; i++)
            {
                if( i == 0)
                {
                    min = arr[i];
                    max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }


            return (min, max);
        }


        static void DebugMatrix(int[,] matrix)
        {
            Console.WriteLine($"The matrix looks like this: \n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");   
                }
                Console.WriteLine();
            }
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