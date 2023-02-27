// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();
 
int M = Input("Введите минимальное число");
int N = Input("Введите максимальное число");

NumberListRec(M, N);

void NumberListRec(int a, int b)
{
    int count = a;
    Console.Write($"{count} ");
    if(a == b) return;
    else NumberListRec(a + 1, b);
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}