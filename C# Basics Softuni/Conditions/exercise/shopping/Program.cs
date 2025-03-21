double petersBudget = double.Parse(Console.ReadLine());
int gpu = int.Parse(Console.ReadLine());
int cpu = int.Parse(Console.ReadLine());
double ram = double.Parse(Console.ReadLine());

double gpuPrice = gpu * 250;
double cpuPrice = gpuPrice * 0.35 * cpu;
double ramPrice = gpuPrice * 0.10 * ram;

double total = gpuPrice + cpuPrice + ramPrice;

if(gpu > cpu)
{
    total *= 0.85;
}

if(petersBudget >= total)
{
    Console.WriteLine($"You have {petersBudget - total:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {total - petersBudget:F2} leva more!");
}

