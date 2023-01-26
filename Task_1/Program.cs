//Проверка квадрата числа 

Console.Clear ();
Console.Write ("Введите число один: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int sqr1 = number1*number1;
int sqr2 = number2*number2;

if (number1==sqr2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (number2==sqr1)
    {
    Console.WriteLine("Второе число является квадратом первого");
    }
Console.WriteLine("Нет числа квадратного");
