int anualTrainingTax = int.Parse(Console.ReadLine());

double sneakersPrice = anualTrainingTax - (anualTrainingTax * 0.40);
double outfitPrice = sneakersPrice - (sneakersPrice * 0.20);
double ballPrice = outfitPrice / 4;
double accessoriesPrice = ballPrice / 5;

double totalSum = anualTrainingTax + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalSum);