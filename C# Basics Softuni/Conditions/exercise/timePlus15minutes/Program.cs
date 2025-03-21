int houres = int.Parse(Console.ReadLine());
int mins = int.Parse(Console.ReadLine());

mins += 15;

if(mins >= 60)
{
    houres++;
}
if(houres >= 24)
{
    houres = 0;
}

mins %= 60;

Console.WriteLine($"{houres}:{mins:D2}");