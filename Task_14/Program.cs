// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число: ");
double N = double.Parse(Console.ReadLine());
double a = 1;
double b = 1;
while(a < N)
{
    b = Math.Pow(a ,2);
    a++;
    Console.Write(b + ", ");
}
    N = Math.Pow(N ,2);
    Console.Write(N);