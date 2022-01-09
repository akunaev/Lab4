double Sum = 1000;
double Sum2 = Sum * 2;
double p = 4;
int year = 0;

do
{
    Sum += Sum * p / 100;
    year++;
} while (Sum < Sum2);

Console.WriteLine(year);
Console.ReadKey();