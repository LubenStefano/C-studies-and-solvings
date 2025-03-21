double a = double.Parse(Console.ReadLine());
double num = 0;

if(a % 2 == 0)
{
 num +=1;
}
else if(a % 5 == 0)
{
    num +=2;
}
if(a <= 100)
{
    num+=5;
}
else if( a <= 1000)
{
    num += a * 20/100;
}
else
{
    num += a * 10/100;
}
Console.WriteLine(num);
Console.WriteLine(num + a);