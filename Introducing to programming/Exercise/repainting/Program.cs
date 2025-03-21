int plastic = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());

double plasticPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;

double plasticSum = (plastic + 2) * plasticPrice;
double paintSum = (paint + (paint * 0.10)) * paintPrice;
double thinnerSum = thinner * thinnerPrice;

double totalMaterialSum = plasticSum + paintSum + thinnerSum + 0.40;
double workingHoursPrice = totalMaterialSum * 0.30 * workingHours;

Console.WriteLine(totalMaterialSum + workingHoursPrice);