﻿// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 782 -> 72 918 -> 98

Console.Clear();
int num = new Random().Next(100, 1000);
int n1 = num/100;
int n2 = num%10;
int n3 = (n1*10) + n2;

Console.WriteLine($"{num} -> {n3}");