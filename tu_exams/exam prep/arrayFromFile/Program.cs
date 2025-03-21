namespace arrayFromFile;

class Program 
{
    static void Main(string[] args)
    {
       string path = Console.ReadLine();
       
       int[] arr = ReadArrayFromFile(path);
       bool isSorted = IsSorted(arr);

    }

    static int[] ReadArrayFromFile(string path)
    {
        string data  = File.ReadAllText(path);

        string[] stringArr = data.Split(", ");

        int[] arr = new int[stringArr.Length];

        for(int i = 0; i < arr.Length; i ++)
        {
            arr[i] = int.Parse(stringArr[i]);
            Console.Write($"{arr[i] }");
        }

        return arr;
    }

    static bool IsSorted(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = 0; i < arr.Length - i- 1; j++)
            {
                if(arr[j] < arr[j+1])
                {
                    Console.WriteLine($"FALSE");
                    
                    return false;
                }
            }
        }
        Console.WriteLine($"TRUE");
        
        return true;
    }
}
