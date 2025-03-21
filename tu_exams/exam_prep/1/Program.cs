using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lubo_sHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for(int i=0; i < size; i++)
            {
                Console.Write($"Enter the value af the array {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"The array is: ");
            for(int i=0; i<size; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}