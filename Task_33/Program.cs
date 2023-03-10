// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");

int[,] array = getArray(rows, colunns, 0 , 10);
int[,] sum = array;
PrintArray(array);
Console.WriteLine();
getNewArrayV2(array);
PrintArray(array);

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


// int[,] getNewArray(int[,] inArray)
// {
//     int[,] newArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
//     for(int i=0; i <inArray.GetLength(0) -1 ; i++)
//     {
//         for(int j=0; j < inArray.GetLength(1); j++)
//         {
//             if(i != 0)
//             {
//             newArray[i,j] = inArray[i,j];
//             }
//             else
//             {
//                 newArray[i, j] = inArray[inArray.GetLength(0) - 1, j];
//                 newArray[inArray.GetLength(0) - 1, j] = inArray[i, j];
//             }

//         }
//     }
//     return newArray;
// }

void getNewArrayV2(int[,] inArray)
{
    int temp;
    for(int j=0; j < inArray.GetLength(1); j++)
    {
        temp = inArray [0,j];
        inArray[0, j] = inArray[inArray.GetLength(0)-1, j];
        inArray[inArray.GetLength(0)-1, j] = temp;
    }
}