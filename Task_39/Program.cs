// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
 
int M = Input("Введите число");
int N = Input("Введите степень");

Console.WriteLine(NumberListRec(M, N));

int NumberListRec(int a, int b)
{
    if(b == 1) return a;
    else
    {
    return a * NumberListRec(a, b-1);
    }
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}