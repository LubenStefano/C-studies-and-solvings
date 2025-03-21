using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Plese put the location to the file that you want to use: ");
        string file = Console.ReadLine();

        Console.Write("Въведете размера на матрицата: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = -1;
            }
        }

        string[] lines = File.ReadAllLines(file);
        int row = 0;
        foreach (string line in lines)
        {
            int col = 0;
            string number = "";
            foreach (char c in line)
            {
                if ((c >= '0' && c <= '9') || c == '-')
                {
                    number += c;
                }
                else if (number.Length > 0)
                {
                    matrix[row, col] = int.Parse(number);
                    number = "";
                    col++;
                }
            }
            if (number.Length > 0)
            {
                matrix[row, col] = int.Parse(number);
            }
            row++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int sumEven = 0, sumOdd = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    sumEven += matrix[i, j];
                }
                else
                {
                    sumOdd += matrix[i, j];
                }
            }
        }
        Console.WriteLine($"Сума на четните елементи: {sumEven}");
        Console.WriteLine($"Сума на нечетните елементи: {sumOdd}");

        int sumEvenRows = 0, sumOddCols = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i % 2 != 0)
                {
                    sumEvenRows += matrix[i, j];
                }
                if (j % 2 == 0)
                {
                    sumOddCols += matrix[i, j];
                }
            }
        }
        Console.WriteLine($"Сума на елементите от четните редове: {sumEvenRows}");
        Console.WriteLine($"Сума на елементите от нечетните колони: {sumOddCols}");
    }
}