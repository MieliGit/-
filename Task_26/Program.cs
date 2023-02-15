// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int n1 = Input("Введите первое число");
Console.WriteLine(Binary(n1));


string Binary(int someNumber)
{
    string str = "";
    do
    {
        str = Convert.ToString(someNumber%2) + str;
        someNumber = someNumber/2;
    }  while(someNumber != 0);
    return str;
}

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}
