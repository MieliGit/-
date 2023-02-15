﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Clear();
int n1 = Input("Введите первое число");
int n2 = Input("Введите второе число");
int n3 = Input("Введите третье число");


if(n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1) Console.WriteLine($"{n1},{n2},{n3} -> могут создать треугольник");
else Console.WriteLine($"{n1},{n2},{n3} -> не могут создать треугольник");



int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}