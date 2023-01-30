// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
int n1 = new Random().Next(-100 , 100);
int n2 = new Random().Next(-100, 100);

int a = n1*n1;
int b = n2*n2;

if(a == n2)
{
    Console.WriteLine($"{n2}, {n1} -> да");
}
else
{
    if(b == n1)
    {
    Console.WriteLine($"{n1}, {n2} -> да");
    }
    else
    {
    Console.WriteLine($"{n1}, {n2} -> нет");
    }   
}

