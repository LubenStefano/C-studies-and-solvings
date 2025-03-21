double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsPerMeter = double.Parse(Console.ReadLine());

double timeNeeded = distanceInMeters * timeInSecondsPerMeter;
double delay = Math.Floor(distanceInMeters / 15) * 12.5;
double totalTime = timeNeeded + delay;

if(totalTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
}
