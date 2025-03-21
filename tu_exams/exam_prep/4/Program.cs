using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;

namespace StudyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int x = int.Parse(Console.ReadLine());

            int resultRecursive = Recursive(x);
            Console.WriteLine("Recursive " + resultRecursive);

            int resultIntuitive = ResultIntuitive(x);
            Console.WriteLine("Intuitive " + resultIntuitive);
        }
        public static int Recursive(int x)
        {
            if (x == 1)
            {
                return 0;
            }
            if (x % 2 == 0)
            {
                return 1 + Recursive(x / 2);
            }
            else
            {
                return 1 + Recursive(x * 3 + 1);
            }
        }

        public static int ResultIntuitive(int x)
        {
            int counter = 0;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                    counter++;
                }
                else
                {
                    x = x * 3 + 1;
                    counter++;
                }
            }
            return counter;
        }
    }
}