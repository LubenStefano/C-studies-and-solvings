public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Enter the array length:");
        int arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        FillArr(arr);
        BubbleSort(arr);
        PrintArr(arr);
    }

    public static void FillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter a value for {i} element: ");
            int value = int.Parse(Console.ReadLine());
            arr[i] = value;
        }
    }
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
