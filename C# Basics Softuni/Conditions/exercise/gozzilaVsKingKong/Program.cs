double filmBudget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double pricePerStatist = double.Parse(Console.ReadLine());

double decor = filmBudget * 0.10;
double totalStatistsPrice = statists * pricePerStatist;

if(statists > 150)
{
    totalStatistsPrice *= 0.90;
}

double totalExpenses = decor + totalStatistsPrice;

if(filmBudget >= totalExpenses)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {filmBudget - totalExpenses:F2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Abs(filmBudget - totalExpenses):F2} leva more.");
}