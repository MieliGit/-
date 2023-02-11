// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int size = 123;


int[] array = GetArray(size);
Console.WriteLine();
int count = 0;
CheckCount(array);

int[] GetArray(int size)
{
    int[] res =new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(0, 150);
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

int CheckCount(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 10 && array[i] < 99)
        {
            count++;
        } 
    }
    Console.WriteLine(count);
    return count;
}

