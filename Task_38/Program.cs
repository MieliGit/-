// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Clear();
 
int M = Input("Введите число");

Console.WriteLine(NumberListRec(M));

int NumberListRec(int a)
{
    if(a/10 == 0) return a;
    else 
    {
        return a % 10 + NumberListRec(a/10);
    }
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}