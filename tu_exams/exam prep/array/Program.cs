namespace arrayFromFile;

class Program
{
    static void Main(string[] args)
    {

        int[] arr = ReadArrayFromFile();
        bool isSorted = IsSorted(arr);
        int count = CountTriplets(arr);
    }

    static int[] ReadArrayFromFile()
    {
        string path = Console.ReadLine();

        string data = File.ReadAllText(path); //"1, 2, 3, 4"

        string[] stringArr = data.Split(", "); // {"1", "2", "3", "4"}

        int[] arr = new int[stringArr.Length]; //{0, 0, 0, 0}

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(stringArr[i]);
            Console.Write($"{arr[i]}");
        }

        return arr; // {1, 2, 3, 4}
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++) // {1, 2, 3, 4}
        {
            if (arr[i] < arr[i + 1]) 
            {
                Console.WriteLine($"FALSE");

                return false;
            }
        }
        Console.WriteLine($"TRUE");

        return true;
    }

    static int CountTriplets(int[] arr)
    {
        int count = 0;

        //{1, 2, 3, 1, 1, 1, 2, 2}


        for (int i = 0; i <arr.Length - 2; i++) 
        {
            for (int j = i + 1; j <arr.Length - 1; j++)
            {
                for (int k = j + 1; k <arr.Length; k++)
                {
                    if (arr[i] == arr[j] && arr[j] == arr[k])
                    {
                        Console.WriteLine($"\n the mathes are {arr[i]}, {arr[j]}, {arr[k]} with indexes: {i}, {j}, {k}");
                        
                        count++;
                    }
                }
            }
        }
        Console.WriteLine($"{count}");
        
        return count;
    }
}

//2020 V2 1ZAD
