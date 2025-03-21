using System.IO;
using System;
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/lubo_/Desktop/Studying/matrix.txt";
            if(!File.Exists(path)){
                return;
            }

            string[] lines = File.ReadAllLines(path); 

            int rows = int.Parse(lines[0]);
            int columns = int.Parse(lines[1]);

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++) //for- row
            {
                string[] line = lines[i+2].Split(" "); // from //"3 3 3" -> {"3", "3", "3"}  //get row
            
                for (int j = 0; j < matrix.GetLength(1); j++) //for -column
                {
                   matrix[i, j] = int.Parse(line[j]); //column j 
                }
            }
            
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}