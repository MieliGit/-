// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от 
//  -N до N. 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.WriteLine("Введите целое число");
int Number = int.Parse(Console.ReadLine());
int OneNumber;
int TwoNumber;

if(Number < 0) 
{
    OneNumber = Number;
    TwoNumber = Number*(-1);
}
else
{
    OneNumber = Number*(-1);
    TwoNumber = Number;
}
while(OneNumber < TwoNumber)
{
    Console.Write(OneNumber +", ");
    OneNumber++;
}
Console.WriteLine(TwoNumber);