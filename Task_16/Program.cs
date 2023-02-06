// Задача 26: Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе. 
// 456 -> 3 78 -> 2 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Колличество цифр = {SizeN(n)}");

int SizeN(int number)
{
    int size = 1;
    while(number > 10)
    {
        number = number/10;
        size++;
    }
    return size;
}
