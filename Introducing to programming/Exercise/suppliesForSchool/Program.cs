int penAmount = int.Parse(Console.ReadLine());
int markerAmount = int.Parse(Console.ReadLine());
int cleanerAmount = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double penPrice = 5.80;
double markerPrice = 7.20;
double cleanerPrice = 1.20;

double penSum = penAmount * penPrice;
double markerSum = markerAmount * markerPrice;
double cleanerSum = cleanerAmount * cleanerPrice;

double totalSum = penSum + markerSum + cleanerSum;
double discountSum = totalSum - (totalSum * (discount / 100.0));
double finalSum = discountSum ;

Console.WriteLine(finalSum);