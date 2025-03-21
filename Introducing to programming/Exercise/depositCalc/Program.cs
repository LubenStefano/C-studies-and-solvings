double depositSum = double.Parse(Console.ReadLine());
int due = int.Parse(Console.ReadLine());
double anualPercantage = double.Parse(Console.ReadLine());

double anualPercantageCost = depositSum * (anualPercantage / 100);
double monthlyPercantageCost = anualPercantageCost / 12;
double sum = depositSum + (due * monthlyPercantageCost);

Console.WriteLine(sum);