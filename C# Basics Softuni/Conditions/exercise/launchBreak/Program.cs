string seriesName = Console.ReadLine();
int episodesLength = int.Parse(Console.ReadLine());
int breaksLength = int.Parse(Console.ReadLine());

double lunchBreak = breaksLength * 1.0 / 8;
double rest = breaksLength * 1.0 / 4;
double timeLeft = breaksLength - lunchBreak - rest;

if(timeLeft >= episodesLength)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodesLength)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodesLength - timeLeft)} more minutes.");
}