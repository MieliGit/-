// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));
// ReversArray1(array);
// Console.WriteLine(string.Join(" ", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(string.Join(" ", reversArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] someArray)
{
    for (int i = 0; i < someArray.Length / 2; i++)
    {
        int k = someArray[i];
        someArray[i] = someArray[someArray.Length -1 - i];
        someArray[someArray.Length - 1 - i] = k;
    }
}

int[] ReversArray2(int[] someArray)
{
    int[] result = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        result[i] = someArray[someArray.Length -1 -i];
    }
    return result;
}