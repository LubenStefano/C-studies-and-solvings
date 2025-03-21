using System;

namespace nThElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int iterative = Iterative(n);
            Console.WriteLine($"The iterative is {iterative}");
            int recursive = Recursive(n);
            Console.WriteLine($"The recursive is {recursive}");

        }


        static int Iterative(int n)
        {
            // Създаваме масив за съхранение на стойностите от поредицата
            int[] sequence = new int[n + 1]; // Размер n+1, за да можем да използваме индекси от 1 до n {0,0,0,0,0}

            // Инициализираме първите 4 стойности (базови случаи)
            sequence[1] = 1;  //{0, 1, 0 0}
            sequence[2] = 2; // {0, 1, 2. 0...}
            sequence[3] = 3; //{0, 1, 2, 3, 0...}
            sequence[4] = 5; //{0, 1, 2, 3, 5, 0 ...n}

            if (n <= 4)
            {
                return sequence[n];
            }

            // Итеративно изчисляваме стойностите за i = 5 до n
            for (int i = 5; i <= n; i++)
            {
                // Формулата за N_i
                sequence[i] = sequence[i - 1] + 3 * sequence[i - 3] - 5 * sequence[i - 4];
            }

            // Връщаме резултата за N_n
            return sequence[n];
        }



        static int Recursive(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 3;
            if (n == 4) return 5;

            return Recursive(n - 1) + 3 * Recursive(n - 3) - 5 * Recursive(n - 4);
        }
    }
}

//snimka 2 zad2 s redica