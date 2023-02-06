// Задача 28: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел
// от 1 до N. 4 -> 24 5 -> 120


Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифк = {MultiplyN(n)}");

int MultiplyN(int B)
{
    int multi = 1;
    while(B > 0)
    {
        multi = multi*B;
        B--;
    }
    return multi;
}