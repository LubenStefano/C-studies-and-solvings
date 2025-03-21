using System;
using System.IO;

namespace exam2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1.
            int[] arr = ReadArrayFromFile();
            Console.WriteLine($"The array is: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            //2.
            ReverseInplace(arr);
            Console.WriteLine($"The reversed array is: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //3.
            int maxCount = MostCommonCount(arr);
            Console.WriteLine($"The max count of repeat is: {maxCount}");
        }

        public static int[] ReadArrayFromFile()
        {
            Console.WriteLine("Enter the file path: ");
            string path = Console.ReadLine();

            string content = File.ReadAllText(path); //"1, 2, 3, 4, 5, 6" 
                                                                       
            string[] stringArr = content.Split(", "); // {"1", "2", "3", "4", "5", "6"}

            int[] arr = new int[stringArr.Length]; //{0, 0 ,0 ,0 ,0 ,0} правим масив с дължината на stringАrr

            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }


            return arr; //{1, 2, 3, 4, 5, 6}
        }

        public static int[] ReverseInplace(int[] arr)
        {
            //using bubble 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    int temp = arr[j];
                    int next = arr[j +1];
                    arr[j+1] = temp;
                    arr[j] = next;

                    //arr[j] > arr[j + 1] za 1,2,3
                    //arr[j] < arr[j + 1] za 3, 2, 1
                    //reverse (sega) ot 1,2,8,3 -> 3, 8, 2, 1 
                }
            }
            return arr;
        }

        public static int MostCommonCount(int[] arr) //1, 2, 3, 4, 5, 4
        {
            int maxCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}
