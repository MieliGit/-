﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int num = new Random().Next(10, 100);
int n1 = num/10;
int n2 = num%10;
int max = n1;

if(max < n2) 
{
    max = n2;
}

Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
