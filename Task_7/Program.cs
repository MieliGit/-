﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.Clear();
int n1 = new Random().Next(1, 100);
int n2 = new Random().Next(1, 100);
int n = 0;

if(n1%n2 == 0) 
{
    Console.WriteLine($"{n1}, {n2} -> кратно");
}
else
{
    n = n1%n2;
    Console.WriteLine ($"{n1}, {n2} -> не кратно, остаток {n}");
}

