Console.WriteLine("Въведете n: ");
int n = int.Parse(Console.ReadLine());


int elementBasic = FindListElement(n);
int elementRecirsive = FindListElementRecirsive(n);

Console.WriteLine($"n-тия елемент на редицата е: ");
Console.WriteLine();
Console.WriteLine(elementBasic + " - обикновено решение");
Console.WriteLine(elementRecirsive + " - рекурсивно решение");


//обикновенно решение
int FindListElement(int n)
{
List<int> list = new List<int> { 2, 4, 6 };

if (n <= 3)
{
    return list[n - 1];
}

  for (int i = 4; i <= n; i++)
    {
        int element = 3 * list[i - 4] + 4 * list[i - 3] - 7 * list[i - 2];
        list.Add(element);
    }

    return list[n - 1];
}


//решение с рекурсия
int FindListElementRecirsive(int n)
{
    if (n <= 3)
    {
        return new List<int> { 2, 4, 6 }[n - 1];
    }

    return 3 * FindListElementRecirsive(n - 3) + 4 * FindListElementRecirsive(n - 2) - 7 * FindListElementRecirsive(n - 1);
}