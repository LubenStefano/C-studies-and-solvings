int pageAmount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int timeNeeded = pageAmount / pagesPerHour;
int hoursPerDay = timeNeeded / days;

Console.WriteLine(hoursPerDay);