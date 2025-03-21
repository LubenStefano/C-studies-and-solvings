int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

int volume = length * width * height;
double liters = volume * 0.001;
double percentLiters = percent * 0.01;
double totalLiters = liters * (1 - percentLiters);

Console.WriteLine(totalLiters);