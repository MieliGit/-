// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифк = {SumN(n)}");

int SumN(int B)
{
    int sum = 0;
    while(B > 0)
    {
        sum += B;
        B--;
    }
    return sum;
}