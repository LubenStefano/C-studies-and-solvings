double tripPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double puzzlesPrice = 2.60;
double dollsPrice = 3.00;
double bearsPrice = 4.10;
double minionsPrice = 8.20;
double trucksPrice = 2.00;

int totalToys = puzzles + dolls + bears + minions + trucks;

double totalIncome = (puzzles * puzzlesPrice) + (dolls * dollsPrice) + (bears * bearsPrice) + (minions * minionsPrice) + (trucks * trucksPrice);

if(totalToys >= 50)
{
    totalIncome *= 0.75;
}

totalIncome *= 0.90;

if(totalIncome >= tripPrice)
{
    Console.WriteLine($"Yes! {totalIncome - tripPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripPrice - totalIncome:F2} lv needed.");
}
