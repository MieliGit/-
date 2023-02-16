// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();
int size = Input("Введите размер массива");
int min = Input("Введите минимальное число в массиве");
int max = Input("Введите максималльное число в массиве");

int[] array1 = GetArray(size, min, max);
int[] array2 = CopyArray(array1);

int[] CopyArray(int[] someArray)
{
    int[] res = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        res[i] = someArray [i];
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res =new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    } 
    Console.WriteLine();
    return res;
}

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

