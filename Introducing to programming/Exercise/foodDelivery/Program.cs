int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;

double chickenSum = chickenMenus * chickenMenuPrice;
double fishSum = fishMenus * fishMenuPrice;
double vegetarianSum = vegetarianMenus * vegetarianMenuPrice;

double totalSum = chickenSum + fishSum + vegetarianSum;
double dessertSum = totalSum * 0.20;
double deliverySum = 2.50;

double finalSum = totalSum + dessertSum + deliverySum;

Console.WriteLine(finalSum);