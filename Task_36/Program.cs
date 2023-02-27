// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
 
int n = Input("Введите целое число");
int n1 = 1;
NumberListRec(n, n1);

void NumberListRec(int b, int a)
{
   
    Console.Write($"{a} ");
    if(a == b) return;
    else NumberListRec(b, a + 1);
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}