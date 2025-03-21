using System.Runtime.Intrinsics.Arm;

public class Model
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the rows of the matrix:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the columns of the matrix:");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        //fills the matrix with values
        FillTheMatrix(matrix);
        //it prints the matrix
        PrintMatrix(matrix);
        //sum of elements
        int sumElements = SumElements(matrix);
        Console.WriteLine($"The sum of the elements is {sumElements}");
        //check if matrix is identity
        bool isIndentity = CheckIdentity(matrix);
        if (isIndentity)
        {
            Console.WriteLine("The matrix is identity");
        }
        else
        {
            Console.WriteLine("The matrix is NOT identity");
        }
        //sum on antiDiagonal
        int antiSum = SumAntiDiagonal(matrix);
        Console.WriteLine(antiSum);
        int sumDiagonal = SumDiagonal(matrix);
        Console.WriteLine(sumDiagonal);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    public static void FillTheMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine($"Enter the number of the [{i}, {j}] element:");
                int val = int.Parse(Console.ReadLine());
                matrix[i, j] = val;
            }
        }
    }
    public static int SumElements(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }

    public static bool CheckIdentity(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j) //ако i== j то си на главния диагонал
                {
                    if (matrix[i, j] != 1)
                    {
                        return false;
                    }
                }
                else if (matrix[i, j] != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static int SumAntiDiagonal(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i < matrix.GetLength(1))
            {
                int value = matrix[i, matrix.GetLength(1) - i - 1];
                sum += value;
            }
        }
        return sum;
    }

    public static int SumDiagonal(int[,] matrix)
    {
        int sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j) //ако i== j то си на главния диагонал
                {
                    sum+=matrix[i,j];
                }

            }
        }
        return sum;
    }
}