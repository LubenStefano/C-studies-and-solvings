int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int timeSum = firstTime + secondTime + thirdTime;
double timeInMinutes = timeSum/60;
double timeInSeconds = timeSum%60;

if(timeInSeconds < 10)
{
    Console.WriteLine($"{timeInMinutes}:0{timeInSeconds}");
}
else
{
    Console.WriteLine($"{timeInMinutes}:{timeInSeconds}");
}