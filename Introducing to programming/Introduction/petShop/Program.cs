int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double dogFoodPrice = dogFood * 2.50;
double catFoodPrice = catFood * 4.00;

double totalPrice = dogFoodPrice + catFoodPrice;

Console.WriteLine($"{totalPrice} lv.");