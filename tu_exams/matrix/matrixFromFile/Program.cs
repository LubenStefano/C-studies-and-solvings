using System;
using System.IO;

public class MatrixOperations
{
    static decimal[,] ReadMatrixFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int rows = int.Parse(lines[0]);
        int columns = int.Parse(lines[1]);
        decimal[,] matrix = new decimal[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] elements = lines[i + 2].Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = decimal.Parse(elements[j]);
            }
        }

        return matrix;
    }

    static void PrintMatrix(decimal[,] matrix, int row, int column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool CheckIdentity(decimal[,] matrix, int row, int column)
    {
        if (row != column) return false;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == j && matrix[i, j] != 1) return false;
                if (i != j && matrix[i, j] != 0) return false;
            }
        }
        return true;
    }

    static decimal SumNegativeOnAntiDiagonal(decimal[,] matrix, int row, int column)
    {
        decimal sum = 0;
        for (int i = 0; i < row; i++)
        {
            if (i < column)
            {
                decimal value = matrix[i, column - i - 1];
                if (value < 0)
                {
                    sum += value;
                }
            }
        }
        return sum;
    }

    static void NormalizeRows(decimal[,] matrix, int row, int column)
    {
        for (int i = 0; i < row; i++)
        {
            decimal rowSum = 0;
            for (int j = 0; j < column; j++)
            {
                rowSum += matrix[i, j] * matrix[i, j];
            }

            decimal norm = (decimal)Math.Sqrt((double)rowSum);
            if (norm != 0)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] /= norm;
                }
            }
        }
    }

    static void SortMatrix(decimal[,] matrix, int row, int column)
    {
        for (int j = 0; j < column; j++)
        {
            decimal[] columnElements = new decimal[row];
            for (int i = 0; i < row; i++)
            {
                columnElements[i] = matrix[i, j];
            }

            if (j % 2 == 0)
            {
                BubbleSort(columnElements, true);
            }
            else
            {
                BubbleSort(columnElements, false);
            }

            for (int i = 0; i < row; i++)
            {
                matrix[i, j] = columnElements[i];
            }
        }
    }

    static void BubbleSort(decimal[] array, bool ascending)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                bool condition = ascending ? array[j] > array[j + 1] : array[j] < array[j + 1];
                if (condition)
                {
                    decimal temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("Напишете path-a до файла:");
        string filePath = Console.ReadLine();
        decimal[,] matrix = ReadMatrixFromFile(filePath);

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        Console.WriteLine("Матрицата:");
        PrintMatrix(matrix, rows, columns);

        Console.WriteLine(); //за четимост в консолата

        bool isIdentity = CheckIdentity(matrix, rows, columns);
        Console.WriteLine($"Матрицата е единична: {isIdentity}");

        Console.WriteLine(); //за четимост в консолата

        decimal sumNegative = SumNegativeOnAntiDiagonal(matrix, rows, columns);
        Console.WriteLine($"Сбор на отрицателните елементи на вторичния диагонал: {sumNegative}");

        Console.WriteLine();//за четимост в консолата

        NormalizeRows(matrix, rows, columns);
        Console.WriteLine("Нормализирана матрица:");
        PrintMatrix(matrix, rows, columns);

        Console.WriteLine();//за четимост в консолата

        SortMatrix(matrix, rows, columns);
        Console.WriteLine("Матрица след сортиране на колоните:");
        PrintMatrix(matrix, rows, columns);
    }
}
