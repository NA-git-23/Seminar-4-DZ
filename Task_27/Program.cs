﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12


Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (a>0)
{
s = s + (a % 10);
a=a/10;
}

Console.WriteLine($"Сумма цифр в числе:  {s}");
