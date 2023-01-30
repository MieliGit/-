// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz»,
// а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5, 
// то программа должна выводить слово «FizzBuzz».

Console.Clear();
int n = 0;

while(n < 101)
{
    n++;
    if(n%3%5 == 0) 
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        if(n%3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
           if(n%5 == 0)
            {
            Console.WriteLine("Buzz");
            }
        else
            {
           Console.WriteLine(n + ", ");
            }
        }
    }
}
