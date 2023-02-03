// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти графика(От 1 до 4): ");
int N = int.Parse(Console.ReadLine());

if(N < 0 || N > 5)
{
    Console.WriteLine("Введено неверное число");
}
if(N == 1)
{
    Console.WriteLine("X>0; Y>0");
}
if(N == 2)
{
    Console.WriteLine("X<0; Y>0");
}
if(N == 3)
{
    Console.WriteLine("X<0; Y<0");
}
if(N == 4)
{
    Console.WriteLine("X>0; Y<0");
}