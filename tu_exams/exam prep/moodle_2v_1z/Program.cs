using System;

namespace moodle_2v_1z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ReadArrayFromFile();

            //debuging ---
            Console.Write($"The array is: "); 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
             Console.WriteLine();
            //-------

            ReverseInplace(arr);

            //debuging ---
            Console.Write($"The array is: "); 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            
            //-------

            int mostCommon = MostCommonCount(arr);

            //for debuging
            Console.WriteLine($"The most common count of a num is: {mostCommon}");
            //-----

        }

        static int[] ReadArrayFromFile()
        {
            Console.WriteLine($"Enter the path for the file: ");
            string path = Console.ReadLine(); 
            //1,2,3,4,5

            string data = File.ReadAllText(path); //"1,2,3,4,5" 

            string[] arrString = data.Split(","); //{"1", "2", "3", "4", "5"}
            
            int[] arr = new int [arrString.Length]; // {0, 0, 0, 0, 0}

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrString[i]);
            }
            //{1, 2, 3, 4, 5}
            return arr;            
        }

        static void ReverseInplace(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i ++)
            {
                for(int j = 0; j < arr.Length - i - 1; j ++)
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j + 1] = temp;
                }
            }
        }

        static int MostCommonCount(int[] arr)
        {
            int maxCount = 0;

            for(int i = 0; i < arr.Length; i ++)
            {
                int count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count > maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }
    }
}
