﻿double Sum = 1000;
double Sum2 = Sum * 2;
double p = 4;
int year = 0;

while(Sum<Sum2)
{
    Sum += Sum * p / 100;
    year++;
}

Console.WriteLine(year);
Console.ReadKey();