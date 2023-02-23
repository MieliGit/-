// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");

int[,] array = getArray(rows, colunns, 0 , 10);
int[,] sum = array;
PrintArray(array);
Console.WriteLine();
if(rows == colunns) 
{
    array = getNewArray(array); 
    PrintArray(array);
}
else Console.WriteLine("Ваше действие произвести невозможно");
Console.WriteLine();

int[,] getArray( int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}


int[,] getNewArray(int[,] inArray)
{
    int[,] newArray = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for(int i=0; i <inArray.GetLength(0); i++)
    {
        for(int j=0; j < inArray.GetLength(1); j++)
        {
            newArray[j, i] = inArray[i, j];
        }
    }
    return newArray;
}
