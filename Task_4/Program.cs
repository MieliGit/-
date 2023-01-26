// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6 782 -> 2 918 -> 8

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int Number = int.Parse(Console.ReadLine());

if(Number > 999)
{
    Console.WriteLine ("Введено неверное число");
}
else 
{
    Number= Number%100%10;
    Console.WriteLine(Number);
}

   