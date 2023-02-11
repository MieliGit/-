// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве: ");
int max = int.Parse(Console.ReadLine());

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res =new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    } 
    return res;
}
int[]  array = GetArray(size, min, max);
int  ReversNumber = 0;

Console.WriteLine();

foreach(int el in array)
{
    ReversNumber = el * -1;
    Console.Write($"{ReversNumber} ");
}
