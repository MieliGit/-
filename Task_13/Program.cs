// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine("Введите X1: ");
long x1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
long x2 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
long y1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
long y2 = long.Parse(Console.ReadLine());


double result = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
Console.WriteLine(result);

